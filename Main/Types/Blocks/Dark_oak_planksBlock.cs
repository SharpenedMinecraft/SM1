
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_planksBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_planks";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_planksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(20, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dark_oak_planksItem() };

        }
    }
}
