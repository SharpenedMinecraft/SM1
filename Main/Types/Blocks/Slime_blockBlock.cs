
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Slime_blockBlock : Block
    {
        public override string BlockId => "minecraft:slime_block";
        public override BlockState[] PossibleStates { get; }
        public Slime_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6474, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Slime_blockItem() };

        }
    }
}
