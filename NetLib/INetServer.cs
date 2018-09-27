using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.NetLib
{
    public interface INetServer
    {
        void SendToAll(INetPacket packet, Func<NetUser, bool> predicate);
        void SendTo(INetPacket packet, NetUser user);
    }
}
