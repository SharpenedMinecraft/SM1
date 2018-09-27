
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:white_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public White_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8295, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8296, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8297, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8298, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_glazed_terracottaItem() };

        }
    }
}
