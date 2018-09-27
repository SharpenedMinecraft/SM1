
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class BricksBlock : Block
    {
        public override string BlockId => "minecraft:bricks";
        public override BlockState[] PossibleStates { get; }
        public BricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1107, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new BricksItem() };

        }
    }
}
