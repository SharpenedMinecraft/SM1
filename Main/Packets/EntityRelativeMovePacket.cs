using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class EntityRelativeMovePacket : MinecraftPacket
    {
        public EntityRelativeMovePacket(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x27;

        public BaseEntity Entity;

        public override void WritePacket()
        {
            Write((VarInt)Entity.EntityId);
            Write((short)(Entity.LastTransform.Position.X * 32 - Entity.Transform.Position.X * 32) * 128);
            Write((short)(Entity.LastTransform.Position.Y * 32 - Entity.Transform.Position.Y * 32) * 128);
            Write((short)(Entity.LastTransform.Position.Z * 32 - Entity.Transform.Position.Z * 32) * 128);
            Write(Entity.OnGround);
        }
    }
}
