
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:blue_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Blue_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5797, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_terracottaItem() };

        }
    }
}
