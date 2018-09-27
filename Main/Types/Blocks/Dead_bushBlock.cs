
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dead_bushBlock : Block
    {
        public override string BlockId => "minecraft:dead_bush";
        public override BlockState[] PossibleStates { get; }
        public Dead_bushBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1025, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dead_bushItem() };

        }
    }
}
