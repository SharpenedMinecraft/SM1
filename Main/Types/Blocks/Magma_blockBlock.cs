
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magma_blockBlock : Block
    {
        public override string BlockId => "minecraft:magma_block";
        public override BlockState[] PossibleStates { get; }
        public Magma_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8174, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magma_blockItem() };

        }
    }
}
