using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class CloseWindowPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x13;

        public CloseWindowPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var WindowId = Read<byte>();
            //TODO: Window Implementation
            Player.CloseWindow(WindowId);
        }
    }
}
