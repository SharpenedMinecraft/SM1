using fNbt;
using fNbt.Tags;
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SharpenedMinecraft.Types
{
    public abstract class ItemStack 
    {
        public static ItemStack Null => new NullItem();

        public abstract string Id { get; }
        public abstract Int32 ProtocolId { get; }
        public byte ItemCount { get; set; }
        public int Damage { get; set; }
        public bool Unbreakable { get; set; }

        public ItemStack()
        {
            ItemCount = 0;
        }

        public virtual NbtCompound GetNbt()
        {
            return new NbtCompound()
            {
                new NbtByte("Count", ItemCount),
                //new NbtByte("Slot", SlotAt) // the slot its at [ OPTIONAL ]
                new NbtString("id", Id),
                new NbtCompound("tag")
                {
                    new NbtInt("Damage", Damage),
                    new NbtByte("Unbreakable", Unbreakable ? (byte)1 : (byte)0),
                    new NbtList("CanDestroy", NbtTagType.String)
                    {
                        //TODO: Adventure Mode Can Destroy
                    }
                }
            };
        }

        public virtual void SetNbt(NbtCompound nbt)
        {
            ItemCount = nbt["Count"].ByteValue;
            // Id = nbt["id"].StringValue
            var tag = nbt.Get<NbtCompound>("tag");
            Damage = tag["Damage"].IntValue;
            Unbreakable = tag["Unbreakable"].ByteValue != 0;
            // CanDestroy = tag["CanDestroy"].ListValue;
        }

        public static ItemStack GetItem(Int16 itemId)
        {
            Initialize();
            return (ItemStack)Activator.CreateInstance(ItemTypes[itemId]);
        }

        public override String ToString()
        {
            return this.GetType().Name;
        }

        public virtual void OnUse(World world, Vector3 Pos, Player player) { }

        private static bool Initialized = false;
        private static Dictionary<int, Type> ItemTypes = new Dictionary<int, Type>();
        public static void Initialize()
        {
            //Same at blocks
            //TODO: Aaah, the performance
            if (Initialized) return;
            Initialized = true;
            var t = typeof(ItemStack);                       //These are quite some
            var t2 = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(t));
            foreach (var v in t2)
            {
                if (v.IsAbstract)
                    continue;
                var t3 = (ItemStack)Activator.CreateInstance(v);
                RegisterItem(t3);
            }
        }

        public static void RegisterItem(ItemStack item)
        {
            ItemTypes.Add(item.ProtocolId, item.GetType());
        }
    }
}
