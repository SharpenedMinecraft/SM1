
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gold_blockBlock : Block
    {
        public override string BlockId => "minecraft:gold_block";
        public override BlockState[] PossibleStates { get; }
        public Gold_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1105, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gold_blockItem() };

        }
    }
}
