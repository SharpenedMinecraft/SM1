using SharpenedMinecraft.Types.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class HeldItemChangePaket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x3C;

        public HeldItemChangePaket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var newSlot = Read<Int16>();
            Player.Inventory.SelectedSlot = newSlot;
        }
    }
}
