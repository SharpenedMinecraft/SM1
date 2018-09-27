
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:magenta_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Magenta_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5788, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_terracottaItem() };

        }
    }
}
