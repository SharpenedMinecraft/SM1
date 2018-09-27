
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class TerracottaBlock : Block
    {
        public override string BlockId => "minecraft:terracotta";
        public override BlockState[] PossibleStates { get; }
        public TerracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6821, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new TerracottaItem() };

        }
    }
}
