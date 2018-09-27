
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brain_coralBlock : Block
    {
        public override string BlockId => "minecraft:brain_coral";
        public override BlockState[] PossibleStates { get; }
        public Brain_coralBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8442, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brain_coralItem() };

        }
    }
}
