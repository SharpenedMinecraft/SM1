
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:pink_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Pink_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8319, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8320, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8321, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8322, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_glazed_terracottaItem() };

        }
    }
}
