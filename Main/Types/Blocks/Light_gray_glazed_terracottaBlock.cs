
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8327, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8328, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8329, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8330, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_gray_glazed_terracottaItem() };

        }
    }
}
