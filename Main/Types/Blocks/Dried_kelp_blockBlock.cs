
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dried_kelp_blockBlock : Block
    {
        public override string BlockId => "minecraft:dried_kelp_block";
        public override BlockState[] PossibleStates { get; }
        public Dried_kelp_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8418, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dried_kelp_blockItem() };

        }
    }
}
