using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Packets
{
    public class EntityPresentPacket : MinecraftPacket
    {
        public EntityPresentPacket(MinecraftClient client) : base(client)
        {
        }

        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x26;

        public BaseEntity Entity;

        public override void WritePacket()
        {
            Write((VarInt)Entity.EntityId);
        }
    }
}
