
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Sea_lanternBlock : Block
    {
        public override string BlockId => "minecraft:sea_lantern";
        public override BlockState[] PossibleStates { get; }
        public Sea_lanternBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6801, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Sea_lanternItem() };

        }
    }
}
