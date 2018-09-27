using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.NetLib;
using SharpenedMinecraft.Packets;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpenedMinecraft
{
    public class MinecraftClient : NetUser
    {
        public static List<MinecraftPacket> Packets { get; set; }
        static MinecraftClient()
        {
            Packets = new List<MinecraftPacket>();
            var mcPacketType = typeof(MinecraftPacket);
            foreach (var t in Assembly.GetExecutingAssembly()
                .GetTypes().Where(x => x.IsSubclassOf(mcPacketType) && x != mcPacketType))
            {
                Packets.Add((MinecraftPacket)Activator.CreateInstance(t, new object[] { null }));
            }
        }

        public Player Player { get; set; }
        public RijndaelManaged Crypto { get; set; }
        public World World { get; set; }
        public bool Encryption => Crypto != null;
        public State state = State.Handshaking;
        public TeleportManager TeleportManager { get; set; }
        public TimeSpan Ping { get; set; }
        public new MinecraftServer Server => (MinecraftServer)base.Server;
        private Task WriteWorker { get; set; }
        private Queue<INetPacket> WriteQueue { get; set; }
        private CancellationTokenSource CancellationToken { get; set; }
        private bool ToClose = false;

        public MinecraftClient()
        {
            World = World.Overworld;
            Player = new Player(this);
            CancellationToken = new CancellationTokenSource();
            WriteQueue = new Queue<INetPacket>();
            TeleportManager = new TeleportManager();
            WriteWorker = WriteWork();
            Ping = TimeSpan.MinValue;
        }

        public void Close()
        {
            ToClose = true;
        }

        public override void Send(INetPacket p)
        {
            WriteQueue.Enqueue(p);
        }

        private async Task WriteWork()
        {
            while (!CancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (ToClose)
                    {
                        Client.Close();
                        return;
                    }
                    if (WriteQueue.TryDequeue(out INetPacket res))
                    {
                        SendToStream(res);
                    }
                    else
                        await Task.Delay(10, CancellationToken.Token);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"At WriteWork: {Environment.NewLine}{ex}");
                }
            }
        }

        private void SendToStream(INetPacket p)
        {
            try
            {
                lock (Stream)
                {
                    var Packet = (MinecraftPacket)p;
                    Packet.Client = this;
                    Packet.Initialize(0, null);
                    //Here we can add Length & Id etc.
                    Packet.Write<VarInt>(Packet.Id);
                    Packet.WritePacket();
                    var v = new MemoryStream();
                    new MinecraftVarInt(v).Write(Packet.Buffer.Length);
                    var l = v.ToArray();
                    var l2 = JoinArrays(l, Packet.Buffer);
                    //Caught! we need to add @Crypto too
                    Stream.Write(l2, 0, l2.Length);
                    Console.WriteLine($"Send {Packet.GetType().Name} ({Packet.Id.ToString("X")}) ({l2.Length})");
                    Stream.Flush();
                }
            }
            catch (SocketException ex)
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private T[] JoinArrays<T>(T[] array1, T[] array2)
        {
            T[] newArray = new T[array1.Length + array2.Length];
            Array.Copy(array1, newArray, array1.Length);
            Array.Copy(array2, 0, newArray, array1.Length, array2.Length);
            return newArray;
        }
        
        public override void HandlePacket(INetPacket v)
        {
            lock (Stream)
            {
                var p = (MinecraftPacket)v;
                //Here any Read Logic Goes
                var id = p.Read<VarInt>();
                var Packet = GetPacket(id, true);
                Console.WriteLine($"Received Packet {Packet.Id.ToString("X")} ({Packet.GetType().Name}) ({Packet.Length})");
                Packet.Client = this;
                Packet.Initialize(p.Length, p.MemoryStream);
                Packet.ReadPacket();
                Stream.Flush();
            }
        }

        private MinecraftPacket GetPacket(INetPacket packet, bool serverbound)
            => GetPacket(((MinecraftPacket)packet).Id, serverbound);

        private MinecraftPacket GetPacket(int id, bool serverbound)
        {
            try
            {
                return Packets.First(x => x.Id == id && x.State == state && x.Serverbound == serverbound);
            }
            catch
            {
                Console.WriteLine("Coudnt Find Packet 0x" + id.ToString("X"));
                throw;
            }
        }

        public override INetPacket GetPacket(NetworkStream stream)
        {
            var v =  new MinecraftPacket(this);
            var length = MinecraftPacket.ReadFromStream<VarInt>(stream);
            v.Initialize(length, stream);
            return v;
        }

        /*protected override void OnConnected()
        {
        }

        protected override void OnDisconnected()
        {
        }

        protected override void OnSocketError(SocketError socketError)
        {
        }*/

        const int SendDelay = 20;
        const int ReceiveDelay = 30;
        private Task KeepAliveWorker;
        private long LastKeepAlive;
        private bool Received;
        public void StartKeepAlive()
        {
            Console.WriteLine("--- Keep Alive has started ---");
            KeepAliveWorker = KeepAliveWork();
        }

        public async Task KeepAliveWork()
        {
            while (!this.CancellationToken.IsCancellationRequested)
            {
                this.Send(new KeepAlivePacketClient(this));


                var waitT = new TimeSpan(0, 0, 0, ReceiveDelay).TotalMilliseconds;
                Stopwatch s = new Stopwatch();
                s.Start();
                long i = 0;
                while (true)
                {
                    await Task.Delay(5); //Shoud be fine
                    i += 5;
                    if (i >= waitT || Received)
                        break;
                }

                if (!Received)
                {
                    Ping = TimeSpan.MinValue;
                    throw new TimeoutException("Keep Alive Timeout");
                }
                s.Stop();
                Ping = s.Elapsed;
                Send(new PlayerListItem(this) {
                    Action = Enums.PlayerListAction.UpdateLatency,
                    players = new Player[] { this.Player } //Technically Optimizable...
                });
                var t = TimeSpan.FromSeconds(SendDelay) - Ping;
                await Task.Delay(t);
            }
        }

        public void ReceivedKeepAlive(long keepAliveID)
        {
            Console.WriteLine("--- A KeepAlive has been received ---");
            if (keepAliveID != LastKeepAlive)
                throw new Exception("Wrong Keep Alive ID");

            Received = true;
        }

        public void SendKeepAlive(long keepAliveID)
        {
            Console.WriteLine("--- A KeepAlive has been send ---");
            LastKeepAlive = keepAliveID;
            Received = false;
        }

        public void EndConnection(string reason)
        {
            Console.WriteLine("End Connection");
            Close(); //TODO: Propper End Connection
        }
    }
}
