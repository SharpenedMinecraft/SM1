
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Polished_graniteBlock : Block
    {
        public override string BlockId => "minecraft:polished_granite";
        public override BlockState[] PossibleStates { get; }
        public Polished_graniteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Polished_graniteItem() };

        }
    }
}
