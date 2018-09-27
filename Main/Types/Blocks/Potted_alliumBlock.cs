
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_alliumBlock : Block
    {
        public override string BlockId => "minecraft:potted_allium";
        public override BlockState[] PossibleStates { get; }
        public Potted_alliumBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5258, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
