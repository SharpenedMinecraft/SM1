
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5794, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_gray_terracottaItem() };

        }
    }
}
