
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_tulipBlock : Block
    {
        public override string BlockId => "minecraft:white_tulip";
        public override BlockState[] PossibleStates { get; }
        public White_tulipBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1100, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_tulipItem() };

        }
    }
}
