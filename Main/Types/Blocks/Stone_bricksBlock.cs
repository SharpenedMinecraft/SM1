
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stone_bricksBlock : Block
    {
        public override string BlockId => "minecraft:stone_bricks";
        public override BlockState[] PossibleStates { get; }
        public Stone_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3965, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Stone_bricksItem() };

        }
    }
}
