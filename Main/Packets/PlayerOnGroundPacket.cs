using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PlayerOnGroundPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x0C;

        public PlayerOnGroundPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var onGround = Read<Boolean>();
            Player.OnGround = onGround;
        }
    }
}
