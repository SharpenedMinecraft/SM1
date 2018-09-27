using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class KeepAlivePacketServer : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x0B;

        public long KeepAliveID;

        public KeepAlivePacketServer(MinecraftClient client)
            : base(client)
        {
            
        }

        public override void ReadPacket()
        {
            KeepAliveID = Read<Int64>();
            Client.ReceivedKeepAlive(KeepAliveID);
        }
    }
}
