
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class DandelionBlock : Block
    {
        public override string BlockId => "minecraft:dandelion";
        public override BlockState[] PossibleStates { get; }
        public DandelionBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1093, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new DandelionItem() };

        }
    }
}
