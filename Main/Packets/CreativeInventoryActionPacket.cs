using SharpenedMinecraft.Types.Enums;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Packets
{
    public class CreativeInventoryActionPacket : MinecraftPacket
    {
        public override State State => State.Play;
        public override bool Serverbound => true;
        public override int Id => 0x1B;

        public CreativeInventoryActionPacket(MinecraftClient client)
            : base(client)
        {

        }

        public override void ReadPacket()
        {
            var slot = Read<Int16>();
            var clickedItem = Read<ItemStack>();
            Player.Inventory.SetSlot(slot, clickedItem);
        }
    }
}
