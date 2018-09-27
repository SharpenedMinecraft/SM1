
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SunflowerBlock : Block
    {
        public override string BlockId => "minecraft:sunflower";
        public override BlockState[] PossibleStates { get; }
        public SunflowerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6824, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(6825, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new SunflowerItem() };

        }
    }
}
