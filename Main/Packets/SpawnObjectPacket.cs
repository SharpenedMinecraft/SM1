using System;
using System.Collections.Generic;
using System.Text;
using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;

namespace SharpenedMinecraft.Packets
{
    public class SpawnObjectPacket : MinecraftPacket
    {
        public override Int32 Id => 0x00;
        public override State State => State.Play;
        public override Boolean Clientbound => true;

        public SpawnObjectPacket(MinecraftClient client) : base(client)
        {

        }

        public BaseEntity entity;

        public override void WritePacket()
        {
            Write((VarInt)entity.EntityId);
            Write((UInt128)entity.UUID.ToUInt128());
            Write((byte)entity.SpawnId);
            Write((double)entity.Transform.Position.X);
            Write((double)entity.Transform.Position.Y);
            Write((double)entity.Transform.Position.Z);
            Write((byte)Rotation.ToLesser(entity.Transform.Rotation.Pitch));
            Write((byte)Rotation.ToLesser(entity.Transform.Rotation.Yaw));
            Write((int)1); //TODO: Implement Object Data
            Write((short)Vector3F.ConvertToVelocity(entity.Velocity.X));
            Write((short)Vector3F.ConvertToVelocity(entity.Velocity.Y));
            Write((short)Vector3F.ConvertToVelocity(entity.Velocity.Z));
        }
    }
}
