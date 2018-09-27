
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PoppyBlock : Block
    {
        public override string BlockId => "minecraft:poppy";
        public override BlockState[] PossibleStates { get; }
        public PoppyBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1094, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new PoppyItem() };

        }
    }
}
