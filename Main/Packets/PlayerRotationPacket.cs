using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PlayerRotationPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x0F;

        public PlayerRotationPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var yaw = Read<Single>();
            var pitch = Read<Single>();
            var onGround = Read<Boolean>();
            Player.Transform.Rotation.Yaw = yaw;
            Player.Transform.Rotation.Pitch = pitch;
            Player.OnGround = onGround;
        }
    }
}
