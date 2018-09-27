
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Mossy_stone_bricksBlock : Block
    {
        public override string BlockId => "minecraft:mossy_stone_bricks";
        public override BlockState[] PossibleStates { get; }
        public Mossy_stone_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3966, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Mossy_stone_bricksItem() };

        }
    }
}
