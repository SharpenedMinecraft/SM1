using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpenedMinecraft.NetLib
{
    public class NetUser : IDisposable
    {
        public TcpClient Client { get; set; }
        public NetworkStream Stream { get; set; }
        private Task PacketWorker { get; set; }
        private CancellationTokenSource CancellationToken { get; set; }
        public INetServer Server { get; set; }
        public NetUser()
        {
            CancellationToken = new CancellationTokenSource();
        }

        public void Init(TcpClient Client, INetServer server)
        {
            this.Server = server;
            this.Client = Client;
            Stream = this.Client.GetStream();
            PacketWorker = AcceptPackets();
        }

        private async Task AcceptPackets()
        {
            while (!CancellationToken.IsCancellationRequested)
            {
                if (Stream.DataAvailable)
                {
                    try
                    {
                        HandlePacket(GetPacket(Stream));
                    }
                    catch (Exception ex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex);
                        Console.ResetColor();
                    }
                }
                else
                    await Task.Delay(20, CancellationToken.Token);
            }
        }

        public virtual void Send(INetPacket packet)
        {

        }

        public virtual void HandlePacket(INetPacket packet)
        {

        }

        public virtual INetPacket GetPacket(NetworkStream stream) { throw new NotImplementedException(); }

        public void SendToAll(INetPacket packet)
            => SendToAll(packet, x => true);

        public void SendToAll(INetPacket packet, Func<NetUser, bool> Predicate)
        {
            Server.SendToAll(packet, Predicate);
        }

        public void Dispose()
        {
            Client.Close();
            Client.Dispose();
        }
    }
}
