
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Nether_wart_blockBlock : Block
    {
        public override string BlockId => "minecraft:nether_wart_block";
        public override BlockState[] PossibleStates { get; }
        public Nether_wart_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8175, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Nether_wart_blockItem() };

        }
    }
}
