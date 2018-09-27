
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Nether_bricksBlock : Block
    {
        public override string BlockId => "minecraft:nether_bricks";
        public override BlockState[] PossibleStates { get; }
        public Nether_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4477, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Nether_bricksItem() };

        }
    }
}
