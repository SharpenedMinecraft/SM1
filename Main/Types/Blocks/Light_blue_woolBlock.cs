
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_blue_woolBlock : Block
    {
        public override string BlockId => "minecraft:light_blue_wool";
        public override BlockState[] PossibleStates { get; }
        public Light_blue_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1068, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_blue_woolItem() };

        }
    }
}
