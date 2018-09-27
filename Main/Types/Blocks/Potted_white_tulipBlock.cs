
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_white_tulipBlock : Block
    {
        public override string BlockId => "minecraft:potted_white_tulip";
        public override BlockState[] PossibleStates { get; }
        public Potted_white_tulipBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5262, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
