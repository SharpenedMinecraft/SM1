
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3567, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_gray_stained_glassItem() };

        }
    }
}
