
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_oxeye_daisyBlock : Block
    {
        public override string BlockId => "minecraft:potted_oxeye_daisy";
        public override BlockState[] PossibleStates { get; }
        public Potted_oxeye_daisyBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5264, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
