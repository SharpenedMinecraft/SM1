
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class TntBlock : Block
    {
        public override string BlockId => "minecraft:tnt";
        public override BlockState[] PossibleStates { get; }
        public TntBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1108, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new TntItem() };

        }
    }
}
