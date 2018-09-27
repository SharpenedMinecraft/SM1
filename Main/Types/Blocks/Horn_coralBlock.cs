
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Horn_coralBlock : Block
    {
        public override string BlockId => "minecraft:horn_coral";
        public override BlockState[] PossibleStates { get; }
        public Horn_coralBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8445, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Horn_coralItem() };

        }
    }
}
