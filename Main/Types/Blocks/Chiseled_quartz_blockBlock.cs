
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chiseled_quartz_blockBlock : Block
    {
        public override string BlockId => "minecraft:chiseled_quartz_block";
        public override BlockState[] PossibleStates { get; }
        public Chiseled_quartz_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5678, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Chiseled_quartz_blockItem() };

        }
    }
}
