
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purpur_blockBlock : Block
    {
        public override string BlockId => "minecraft:purpur_block";
        public override BlockState[] PossibleStates { get; }
        public Purpur_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8055, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purpur_blockItem() };

        }
    }
}
