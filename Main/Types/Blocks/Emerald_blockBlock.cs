
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Emerald_blockBlock : Block
    {
        public override string BlockId => "minecraft:emerald_block";
        public override BlockState[] PossibleStates { get; }
        public Emerald_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4865, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Emerald_blockItem() };

        }
    }
}
