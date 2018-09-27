
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:pink_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Pink_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5792, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_terracottaItem() };

        }
    }
}
