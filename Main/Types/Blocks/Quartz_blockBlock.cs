
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Quartz_blockBlock : Block
    {
        public override string BlockId => "minecraft:quartz_block";
        public override BlockState[] PossibleStates { get; }
        public Quartz_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5677, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Quartz_blockItem() };

        }
    }
}
