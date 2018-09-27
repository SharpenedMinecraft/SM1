
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class End_stone_bricksBlock : Block
    {
        public override string BlockId => "minecraft:end_stone_bricks";
        public override BlockState[] PossibleStates { get; }
        public End_stone_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8139, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new End_stone_bricksItem() };

        }
    }
}
