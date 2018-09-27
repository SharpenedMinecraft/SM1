using SharpenedMinecraft.DataTypes;
using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class UseItemPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x20;

        public UseItemPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var usedHand = (Hand)(int)Read<VarInt>();
            Player.RightClick(usedHand);
        }
    }
}
