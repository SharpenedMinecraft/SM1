
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oxeye_daisyBlock : Block
    {
        public override string BlockId => "minecraft:oxeye_daisy";
        public override BlockState[] PossibleStates { get; }
        public Oxeye_daisyBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1102, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Oxeye_daisyItem() };

        }
    }
}
