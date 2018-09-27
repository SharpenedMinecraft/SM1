
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_prismarineBlock : Block
    {
        public override string BlockId => "minecraft:dark_prismarine";
        public override BlockState[] PossibleStates { get; }
        public Dark_prismarineBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6542, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dark_prismarineItem() };

        }
    }
}
