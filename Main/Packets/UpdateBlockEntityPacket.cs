using System;
using System.Collections.Generic;
using System.Text;
using fNbt.Tags;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;

namespace SharpenedMinecraft.Packets
{
    public class UpdateBlockEntityPacket : MinecraftPacket
    {
        public override int Id => 0x09;
        public override State State => State.Play;
        public override Boolean Clientbound => true;

        public enum PacketAction : byte
        {
            MobSpawner = 0x01
                //TODO: Implement UpdateBlockEntity
        }

        public Vector3 Position;
        public PacketAction Action;
        public NbtCompound NBT;

        public UpdateBlockEntityPacket(MinecraftClient client) : base(client)
        {
        }

        public override void WritePacket()
        {
            Write(Position);
            Write((byte)Action);
            Write(NBT);
        }
    }
}
