using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.Types
{
    public abstract class Window
    {
        public string Title;
        public byte SlotCount;
        public abstract string Type { get; }
        public Dictionary<short, ItemStack> slots;
        public Player Owner;

        public Window(byte SlotCount, string Title, Player Owner)
        {
            slots = new Dictionary<short, ItemStack>(SlotCount);
            this.SlotCount = SlotCount;
            this.Title = Title;
            this.Owner = Owner;
            for (short i = 0; i <= SlotCount; i++)
                slots.Add(i, ItemStack.Null);
        }
    }
}
