
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class GrassBlock : Block
    {
        public override string BlockId => "minecraft:grass";
        public override BlockState[] PossibleStates { get; }
        public GrassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1023, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new GrassItem() };

        }
    }
}
