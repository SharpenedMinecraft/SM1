using System.Net;

namespace SharpenedMinecraft.NetLib
{
    public class NetServerConfig
    {
        public IPAddress Host { get; set; }
        public int Port { get; set; }
        public int MaximumNumberOfConnections { get; set; }
        public bool OnlineMode { get; set; }

        public NetServerConfig()
        {
            OnlineMode = true;
            Port = 25565;
            Host = IPAddress.Any;
            MaximumNumberOfConnections = 20;
        }
    }
}