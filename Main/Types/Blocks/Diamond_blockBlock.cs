
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Diamond_blockBlock : Block
    {
        public override string BlockId => "minecraft:diamond_block";
        public override BlockState[] PossibleStates { get; }
        public Diamond_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3031, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Diamond_blockItem() };

        }
    }
}
