
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:brown_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Brown_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8343, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8344, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8345, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8346, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_glazed_terracottaItem() };

        }
    }
}
