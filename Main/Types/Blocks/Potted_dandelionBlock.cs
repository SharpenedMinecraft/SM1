
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_dandelionBlock : Block
    {
        public override string BlockId => "minecraft:potted_dandelion";
        public override BlockState[] PossibleStates { get; }
        public Potted_dandelionBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5255, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
