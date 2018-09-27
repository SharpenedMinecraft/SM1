
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Infested_mossy_stone_bricksBlock : Block
    {
        public override string BlockId => "minecraft:infested_mossy_stone_bricks";
        public override BlockState[] PossibleStates { get; }
        public Infested_mossy_stone_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3962, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Infested_mossy_stone_bricksItem() };

        }
    }
}
