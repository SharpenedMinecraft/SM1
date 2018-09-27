
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8383, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_gray_concrete_powderItem() };

        }
    }
}
