
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Nether_wartBlock : Block
    {
        public override string BlockId => "minecraft:nether_wart";
        public override BlockState[] PossibleStates { get; }
        public Nether_wartBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4590, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(4591, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(4592, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(4593, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Nether_wartItem() };

        }
    }
}
