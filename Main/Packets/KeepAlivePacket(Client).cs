using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class KeepAlivePacketClient : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x20;

        public long KeepAliveID;

        public KeepAlivePacketClient(MinecraftClient client)
            : base(client)
        {

        }

        public override void WritePacket()
        {
            KeepAliveID = DateTime.UtcNow.ToBinary();
            Write(KeepAliveID);
            Client.SendKeepAlive(KeepAliveID);
        }
    }
}
