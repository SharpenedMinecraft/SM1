
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:purple_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Purple_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5796, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_terracottaItem() };

        }
    }
}
