
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_carpetBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_carpet";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6813, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_gray_carpetItem() };

        }
    }
}
