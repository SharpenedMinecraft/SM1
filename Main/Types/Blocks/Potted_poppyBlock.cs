
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_poppyBlock : Block
    {
        public override string BlockId => "minecraft:potted_poppy";
        public override BlockState[] PossibleStates { get; }
        public Potted_poppyBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5256, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
