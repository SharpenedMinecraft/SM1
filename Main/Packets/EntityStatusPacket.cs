using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class EntityStatusPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true;
        public override int Id => 0x1C;

        public int EntityId;
        public byte EntityStatus;

        public EntityStatusPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void WritePacket()
        {
            Write((VarInt)EntityId);
            Write(EntityStatus);
        }
    }
}
