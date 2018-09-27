using System;
using System.Collections.Generic;
using System.Text;
using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types.Enums;

namespace SharpenedMinecraft.Packets
{
    public class UpdateEntityMetadataPacket : MinecraftPacket
    {
        public override Int32 Id => 0x3E;
        public override State State => State.Play;
        public override Boolean Clientbound => true;

        public BaseEntity entity;
        public bool force = false;

        public UpdateEntityMetadataPacket(MinecraftClient client) : base(client)
        { }

        public override void WritePacket()
        {
            Write((VarInt)entity.EntityId);
            var metadata = entity.GetMetaData(force);
            Write(metadata);
        }
    }
}
