
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:green_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Green_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8347, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8348, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8349, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8350, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_glazed_terracottaItem() };

        }
    }
}
