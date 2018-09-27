
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class GraniteBlock : Block
    {
        public override string BlockId => "minecraft:granite";
        public override BlockState[] PossibleStates { get; }
        public GraniteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(2, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new GraniteItem() };

        }
    }
}
