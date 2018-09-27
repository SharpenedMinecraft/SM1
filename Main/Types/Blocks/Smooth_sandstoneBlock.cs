
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Smooth_sandstoneBlock : Block
    {
        public override string BlockId => "minecraft:smooth_sandstone";
        public override BlockState[] PossibleStates { get; }
        public Smooth_sandstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7336, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Smooth_sandstoneItem() };

        }
    }
}
