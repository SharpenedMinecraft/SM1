
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:orange_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Orange_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5787, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_terracottaItem() };

        }
    }
}
