
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:yellow_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Yellow_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8311, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8312, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8313, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8314, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_glazed_terracottaItem() };

        }
    }
}
