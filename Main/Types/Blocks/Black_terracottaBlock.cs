
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:black_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Black_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5801, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_terracottaItem() };

        }
    }
}
