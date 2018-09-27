
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Smooth_quartzBlock : Block
    {
        public override string BlockId => "minecraft:smooth_quartz";
        public override BlockState[] PossibleStates { get; }
        public Smooth_quartzBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7337, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Smooth_quartzItem() };

        }
    }
}
