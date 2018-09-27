
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_iceBlock : Block
    {
        public override string BlockId => "minecraft:blue_ice";
        public override BlockState[] PossibleStates { get; }
        public Blue_iceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8474, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_iceItem() };

        }
    }
}
