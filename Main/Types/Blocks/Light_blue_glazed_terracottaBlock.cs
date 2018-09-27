
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_blue_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:light_blue_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Light_blue_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8307, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8308, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8309, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8310, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_blue_glazed_terracottaItem() };

        }
    }
}
