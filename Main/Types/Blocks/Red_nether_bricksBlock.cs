
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_nether_bricksBlock : Block
    {
        public override string BlockId => "minecraft:red_nether_bricks";
        public override BlockState[] PossibleStates { get; }
        public Red_nether_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8176, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_nether_bricksItem() };

        }
    }
}
