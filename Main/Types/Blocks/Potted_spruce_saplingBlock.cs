
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_spruce_saplingBlock : Block
    {
        public override string BlockId => "minecraft:potted_spruce_sapling";
        public override BlockState[] PossibleStates { get; }
        public Potted_spruce_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5249, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
