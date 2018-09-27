using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PlayerPositionAndLookPacketServer : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x0E;

        public Double X;
        public Double FeetY;
        public Double Z;
        public Single Yaw;
        public Single Pitch;
        public Boolean OnGround;

        public PlayerPositionAndLookPacketServer(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            X = Read<Double>();
            FeetY = Read<Double>();
            Z = Read<Double>();
            Yaw = Read<Single>();
            Pitch = Read<Single>();
            OnGround = Read<Boolean>();

            var pos = Player.Transform.Position;
            var rot = Player.Transform.Rotation;

            pos.X = X;
            pos.Y = FeetY;
            pos.Z = Z;
            rot.Yaw = Yaw;
            rot.Pitch = Pitch;

            Player.Transform.Position = pos;
            Player.Transform.Rotation = rot;
            Player.OnGround = OnGround;
        }
    }
}
