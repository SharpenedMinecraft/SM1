
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:lime_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Lime_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8315, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8316, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8317, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8318, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_glazed_terracottaItem() };

        }
    }
}
