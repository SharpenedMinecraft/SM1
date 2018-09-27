
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_red_tulipBlock : Block
    {
        public override string BlockId => "minecraft:potted_red_tulip";
        public override BlockState[] PossibleStates { get; }
        public Potted_red_tulipBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5260, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
