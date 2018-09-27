
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Coal_blockBlock : Block
    {
        public override string BlockId => "minecraft:coal_block";
        public override BlockState[] PossibleStates { get; }
        public Coal_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6822, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Coal_blockItem() };

        }
    }
}
