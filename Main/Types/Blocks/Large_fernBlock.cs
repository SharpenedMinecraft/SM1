
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Large_fernBlock : Block
    {
        public override string BlockId => "minecraft:large_fern";
        public override BlockState[] PossibleStates { get; }
        public Large_fernBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6834, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(6835, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Large_fernItem() };

        }
    }
}
