
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Redstone_blockBlock : Block
    {
        public override string BlockId => "minecraft:redstone_block";
        public override BlockState[] PossibleStates { get; }
        public Redstone_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5665, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Redstone_blockItem() };

        }
    }
}
