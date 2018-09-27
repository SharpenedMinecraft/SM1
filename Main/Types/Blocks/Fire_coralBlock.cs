
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Fire_coralBlock : Block
    {
        public override string BlockId => "minecraft:fire_coral";
        public override BlockState[] PossibleStates { get; }
        public Fire_coralBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8444, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Fire_coralItem() };

        }
    }
}
