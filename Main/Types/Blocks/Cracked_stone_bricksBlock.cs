
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cracked_stone_bricksBlock : Block
    {
        public override string BlockId => "minecraft:cracked_stone_bricks";
        public override BlockState[] PossibleStates { get; }
        public Cracked_stone_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3967, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cracked_stone_bricksItem() };

        }
    }
}
