
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chiseled_stone_bricksBlock : Block
    {
        public override string BlockId => "minecraft:chiseled_stone_bricks";
        public override BlockState[] PossibleStates { get; }
        public Chiseled_stone_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3968, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Chiseled_stone_bricksItem() };

        }
    }
}
