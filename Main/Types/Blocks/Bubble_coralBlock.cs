
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Bubble_coralBlock : Block
    {
        public override string BlockId => "minecraft:bubble_coral";
        public override BlockState[] PossibleStates { get; }
        public Bubble_coralBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8443, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Bubble_coralItem() };

        }
    }
}
