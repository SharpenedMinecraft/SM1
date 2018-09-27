using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class SpawnPlayerPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x05;

        public Player player;

        public SpawnPlayerPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void WritePacket()
        {
            Write((VarInt)player.EntityId);
            Write(player.UUID.ToUInt128());
            Write(player.Transform.Position.X);
            Write(player.Transform.Position.Y);
            Write(Player.Transform.Position.Z);
            Write(Rotation.ToLesser(player.Transform.Rotation.Yaw));
            Write(Rotation.ToLesser(player.Transform.Rotation.Pitch));
            Write((byte)0xff); //TODO: Entity Metadata
        }
    }
}
