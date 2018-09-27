using SharpenedMinecraft.Entities;
using SharpenedMinecraft.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpenedMinecraft.DataTypes
{
    public class MinecraftSlot : MinecraftType<ItemStack>
    {
        public MinecraftSlot(Stream stream) : base(stream)
        { }

        public override ItemStack Read()
        {
            var Uint8 = new MinecraftByte(Stream);
            var ItemId = new MinecraftShort(Stream).Read();
            if (ItemId != -1)
            {
                var Count = Uint8.Read();
                //NBT
                Uint8.Read(); //Just Read Out the NBT
                ItemStack value = ItemStack.GetItem(ItemId);
                value.ItemCount = Count;
                value.SetNbt(new MinecraftNbtCompound(Stream).Read());
                return value;
            }
            else
                return ItemStack.Null;
        }

        public override void Write(ItemStack value)
        {
            var Uint8 = new MinecraftByte(Stream);
            new MinecraftShort(Stream).Write((short)value.ProtocolId);
            if (value.ProtocolId != -1)
            {
                Uint8.Write(value.ItemCount);
                new MinecraftNbtCompound(Stream).Write(value.GetNbt());
            }
        }
    }
}
