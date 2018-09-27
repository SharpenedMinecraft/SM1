
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Iron_blockBlock : Block
    {
        public override string BlockId => "minecraft:iron_block";
        public override BlockState[] PossibleStates { get; }
        public Iron_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1106, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Iron_blockItem() };

        }
    }
}
