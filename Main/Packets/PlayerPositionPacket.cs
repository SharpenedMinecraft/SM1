using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PlayerPositionPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x0D;

        public PlayerPositionPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var x = Read<Double>();
            var FeetY = Read<Double>();
            var z = Read<Double>();
            var onGround = Read<Boolean>();
            Player.NextTransform.Position.X = x;
            Player.NextTransform.Position.Y = FeetY;
            Player.NextTransform.Position.Z = z;
            Player.OnGround = onGround;
        }
    }
}
