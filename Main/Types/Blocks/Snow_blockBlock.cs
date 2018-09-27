
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Snow_blockBlock : Block
    {
        public override string BlockId => "minecraft:snow_block";
        public override BlockState[] PossibleStates { get; }
        public Snow_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3406, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Snow_blockItem() };

        }
    }
}
