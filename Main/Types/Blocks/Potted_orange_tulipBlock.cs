
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_orange_tulipBlock : Block
    {
        public override string BlockId => "minecraft:potted_orange_tulip";
        public override BlockState[] PossibleStates { get; }
        public Potted_orange_tulipBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5261, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
