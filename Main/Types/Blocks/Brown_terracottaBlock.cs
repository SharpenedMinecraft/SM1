
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:brown_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Brown_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5798, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_terracottaItem() };

        }
    }
}
