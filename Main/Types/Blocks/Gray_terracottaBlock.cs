
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:gray_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Gray_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5793, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_terracottaItem() };

        }
    }
}
