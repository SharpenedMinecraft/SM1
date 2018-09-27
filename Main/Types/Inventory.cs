
using SharpenedMinecraft.Packets;
using System.Collections.Generic;
using System.Linq;

namespace SharpenedMinecraft.Types
{
    public class Inventory : Window
    {
        public override string Type => "";

        /*
         Left to Right, Up to Down

         0 	crafting output
        1–4 	2×2 crafting input (1 + x + 2 * y)
        5–8 	armor (head, chest, legs, feet)
        9–35 	main inventory
        36–44 	hotbar
        45 	Offhand slot 
             */
        public short SelectedSlot = 36;
        public ItemStack Selected
        {
            get { return slots[36]; }
            set { slots[36] = value; }
        }
        #region Armor
        public ItemStack Head
        {
            get { return slots[5]; }
            set { slots[5] = value; }
        }
        public ItemStack Chest
        {
            get { return slots[6]; }
            set { slots[6] = value; }
        }
        public ItemStack Legs
        {
            get { return slots[7]; }
            set { slots[7] = value; }
        }
        public ItemStack Feet
        {
            get { return slots[8]; }
            set { slots[8] = value; }
        }
        #endregion
        #region Crafting
        //Hmmm
        #endregion
        public ItemStack[] MainInventory
        {
            get
            {
                return slots.Where(x => x.Key <= 35 && x.Key >= 9).ToDictionary(p => p.Key, p => p.Value).Values.ToArray();
            }
        }
        public ItemStack[] Hotbar
        {
            get
            {
                return slots.Where(x => x.Key <= 36 && x.Key >= 44).ToDictionary(p => p.Key, p => p.Value).Values.ToArray();
            }
        }


        public Inventory(Player Owner) : base(45, "Inventory", Owner)
        {
        }


        public void SetSlot(short slot, ItemStack content)
        {
            slots[slot] = content;
            Owner.Client.Send(new SetSlotPacket(Owner.Client)
            {
                SlotData = content,
                SlotId = slot,
                WindowId = 0
            });
        }
    }
}