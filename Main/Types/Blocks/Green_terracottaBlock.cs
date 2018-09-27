
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:green_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Green_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5799, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_terracottaItem() };

        }
    }
}
