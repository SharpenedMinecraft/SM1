
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:blue_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Blue_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8339, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8340, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8341, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8342, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_glazed_terracottaItem() };

        }
    }
}
