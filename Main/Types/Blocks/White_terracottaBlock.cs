
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:white_terracotta";
        public override BlockState[] PossibleStates { get; }
        public White_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5786, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_terracottaItem() };

        }
    }
}
