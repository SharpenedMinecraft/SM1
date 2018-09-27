
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:orange_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Orange_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8299, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8300, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8301, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8302, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_glazed_terracottaItem() };

        }
    }
}
