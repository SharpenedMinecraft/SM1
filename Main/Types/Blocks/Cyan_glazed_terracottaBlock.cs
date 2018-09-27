
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:cyan_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Cyan_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8331, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8332, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8333, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8334, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_glazed_terracottaItem() };

        }
    }
}
