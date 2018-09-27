
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:purple_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Purple_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8335, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8336, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8337, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8338, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_glazed_terracottaItem() };

        }
    }
}
