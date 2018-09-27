using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class EntityLookPacket : MinecraftPacket
    {
        public EntityLookPacket(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x29;

        public BaseEntity Entity;

        public override void WritePacket()
        {
            Write((VarInt)Entity.EntityId);
                // these funcs give Bytes back ^^ (and convert from 360 Degrees to 256 (second link!)
            Write(Rotation.ToLesser(Entity.Transform.Rotation.Yaw));
            Write(Rotation.ToLesser(Entity.Transform.Rotation.Pitch));
            Write(Entity.OnGround);
        }
    }
}
