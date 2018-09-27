using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class EntityTeleportPacket : MinecraftPacket
    {
        public EntityTeleportPacket(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x4F;

        public BaseEntity Entity;

        public override void WritePacket()
        {
            Write((VarInt)Entity.EntityId);
            Write(Entity.Transform.Position.X);
            Write(Entity.Transform.Position.Y);
            Write(Entity.Transform.Position.Z);
            Write(Rotation.ToLesser(Entity.Transform.Rotation.Yaw));
            Write(Rotation.ToLesser(Entity.Transform.Rotation.Pitch));
            Write(Entity.OnGround);
        }
    }
}
