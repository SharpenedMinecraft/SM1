using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SharpenedMinecraft.Types.Blocks;

namespace SharpenedMinecraft.Types
{
    public abstract class Block : IEquatable<Block>
    {
        public static Block Air => new AirBlock();

        public abstract string BlockId { get; }
        public abstract BlockState[] PossibleStates { get; }
        public int StateId => State.Id;
        public BlockState State { get; set; }
        public int BlockLight { get; set; }
        public int SkyLight { get; set; }
        public ItemStack[] Drops { get; set; }
        public Block()
        {
            //TODO: Lightning
            BlockLight = 9;
            SkyLight = 9;
            Drops = new ItemStack[0];
        }
        public virtual void OnPlace(Vector3 location, Player causing) { }
        public Int32 GetGlobalPaletteIDFromState()
        {
            return State.Id;
        }

        public override String ToString()
        {
            return BlockId;
        }

        public static Block GetBlock(Int32 stateId)
        {
            Initialize();
            return (Block)Activator.CreateInstance(BlockIds[stateId]);
        }

        private static bool Initialized = false;
        private static Dictionary<int, Type> BlockIds = new Dictionary<int, Type>();
        static Block()
        {
            Initialize();
        }
        public static void Initialize()
        {
            //TODO: Aaah, the performance
            if (Initialized) return;
            Initialized = true;
            var t = typeof(Block);                       //These are quite some
            var t2 = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(t));
            int unknown = 0;
            foreach (var v in t2)
            {
                if (v.IsAbstract)
                    continue;
                var t3 = (Block)Activator.CreateInstance(v);
                if (t3.Drops.Count() == 0)
                    unknown++;
                RegisterBlock(t3);
            }
            if (unknown > 0)
                Console.WriteLine($"Detected {unknown} Blocks without Drops");
        }

        public static void RegisterBlock(Block block)
        {
            var v = block.GetType();
            if (block.Drops.Count() == 0)
                Console.WriteLine($"Block {block.BlockId} has no Drops!");
            foreach (var v2 in block.PossibleStates)
                BlockIds.Add(v2.Id, v); // Cool, Coool
        }

        public bool Equals(Block other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return BlockId == other.BlockId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Block) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return BlockId.GetHashCode();
            }
        }

        public static bool operator ==(Block left, Block right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Block left, Block right)
        {
            return !Equals(left, right);
        }
    }
}