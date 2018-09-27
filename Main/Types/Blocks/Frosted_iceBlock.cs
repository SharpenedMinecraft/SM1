
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Frosted_iceBlock : Block
    {
        public override string BlockId => "minecraft:frosted_ice";
        public override BlockState[] PossibleStates { get; }
        public Frosted_iceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8170, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(8171, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(8172, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(8173, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
