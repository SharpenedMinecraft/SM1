
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Prismarine_bricksBlock : Block
    {
        public override string BlockId => "minecraft:prismarine_bricks";
        public override BlockState[] PossibleStates { get; }
        public Prismarine_bricksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6541, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Prismarine_bricksItem() };

        }
    }
}
