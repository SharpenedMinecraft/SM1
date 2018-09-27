
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_oak_saplingBlock : Block
    {
        public override string BlockId => "minecraft:potted_oak_sapling";
        public override BlockState[] PossibleStates { get; }
        public Potted_oak_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5248, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
