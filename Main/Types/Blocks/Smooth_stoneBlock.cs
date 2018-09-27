
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Smooth_stoneBlock : Block
    {
        public override string BlockId => "minecraft:smooth_stone";
        public override BlockState[] PossibleStates { get; }
        public Smooth_stoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7335, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Smooth_stoneItem() };

        }
    }
}
