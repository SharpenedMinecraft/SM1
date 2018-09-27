
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class FernBlock : Block
    {
        public override string BlockId => "minecraft:fern";
        public override BlockState[] PossibleStates { get; }
        public FernBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1024, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new FernItem() };

        }
    }
}
