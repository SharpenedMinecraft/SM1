
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:gray_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Gray_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8323, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8324, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8325, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8326, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_glazed_terracottaItem() };

        }
    }
}
