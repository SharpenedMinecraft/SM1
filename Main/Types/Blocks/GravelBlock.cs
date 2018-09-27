
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class GravelBlock : Block
    {
        public override string BlockId => "minecraft:gravel";
        public override BlockState[] PossibleStates { get; }
        public GravelBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(68, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new GravelItem() };

        }
    }
}
