using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class PlayerPositionAndLookPacketClient : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x31;

        public Double X;
        public Double Y;
        public Double Z;
        public Single Yaw;
        public Single Pitch;
        public TransformFlags Flags;

        //TODO: Teleport ID implementation
        //TODO: Anti-Hack

        public PlayerPositionAndLookPacketClient(MinecraftClient client)
            : base(client)
        {
        }

        public override void Initialize(int length, Stream stream) 
        { 
            base.Initialize(length, stream);
            var transform = Player.Transform;

            X = transform.Position.X;
            Y = transform.Position.Y;
            Z = transform.Position.Z;
            Yaw = transform.Rotation.Yaw;
            Pitch = transform.Rotation.Pitch;
        }

        public override void WritePacket()
        {
            Write(X);
            Write(Y);
            Write(Z);

            Write(Yaw);
            Write(Pitch);

            Write((byte)Flags);

            var v = Client.TeleportManager.StartTeleport(new TeleportInformation());
            Write((VarInt)v);
        }
    }
}
