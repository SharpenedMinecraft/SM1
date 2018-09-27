using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SharpenedMinecraft.NetLib
{
    public class NetServer<T> : INetServer where T : NetUser, new()
    {
        public NetServerConfig Configuration { get; set; }
        private TcpListener Listener { get; set; }
        private Task ListenerWorker { get; set; }
        private CancellationTokenSource CancellationToken { get; set; }
        List<T> Clients = new List<T>();

        public NetServer()
        {
            Configuration = new NetServerConfig();
            CancellationToken = new CancellationTokenSource();
        }

        public void Start()
        {
            try
            {
                Listener = new TcpListener(Configuration.Host, Configuration.Port);
                Listener.Start();
                Initialize();
                ListenerWorker = new Task(async () => await Listen());
                ListenerWorker.Start();
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        public void Stop()
        {
            try
            {
                CancellationToken.Cancel();
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        private async Task Listen()
        {
            try
            {
                Task CheckerTask = Task.CompletedTask;
                while (!CancellationToken.IsCancellationRequested)
                {
                    if (Clients.Count <= Configuration.MaximumNumberOfConnections && Listener.Pending())
                    {
                        var client = Listener.AcceptTcpClient();
                        var t = new T();
                        t.Init(client, this);
                        Clients.Add(t);
                        this.OnClientConnected(t);
                    }
                    else
                    {
                        if (CheckerTask.IsCompleted)
                            CheckerTask = Task.Run(() => CheckClients());
                        await Task.Delay(10, CancellationToken.Token);
                    }
                }
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        public virtual void SendToAll(INetPacket packet, Func<NetUser, bool> predicate)
        {
            lock(Clients)
                foreach (var v in Clients)
                {
                    if (predicate(v))
                    {
                        SendTo(packet, v);
                    }
                }
        }

        public void SendTo(INetPacket packet, NetUser user)
        {
            lock(Clients)
                if (!Clients.Contains(user))
                    throw new ArgumentException();

            user.Send(packet);
        }

        private void CheckClients()
        {
            try
            {
                for (int i = 0; i < Clients.Count; i++)
                {
                    var v = Clients[i];
                    if (!v.Client.Connected)
                    {
                        Clients.Remove(v);
                        OnClientDisconnected(v);
                    }
                }
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        #region Virtuals
        public virtual void Initialize()
        {

        }

        public virtual void OnClientConnected(T client)
        {

        }

        public virtual void OnClientDisconnected(T client)
        {

        }

        public virtual void OnError(Exception exception)
        {

        }
        #endregion
    }
}
