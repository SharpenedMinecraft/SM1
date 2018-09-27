
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:magenta_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Magenta_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8303, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8304, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8305, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8306, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_glazed_terracottaItem() };

        }
    }
}
