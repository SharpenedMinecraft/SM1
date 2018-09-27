using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class EntityAnimationPacketClient : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Clientbound => true; //Clientbound => true;
        public override int Id => 0x06;

        public EntityAnimationPacketClient(MinecraftClient client)
            : base(client)
        {

        }

        public int EntityId;
        public AnimationType type;

        public override void WritePacket()
        {
            Write((VarInt)EntityId);
            Write((byte)type);
        }
    }
}
