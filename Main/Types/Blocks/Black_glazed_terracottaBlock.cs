
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:black_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Black_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8355, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8356, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8357, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8358, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_glazed_terracottaItem() };

        }
    }
}
