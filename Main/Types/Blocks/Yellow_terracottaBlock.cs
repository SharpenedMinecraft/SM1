
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:yellow_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Yellow_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5790, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_terracottaItem() };

        }
    }
}
