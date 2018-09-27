
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PrismarineBlock : Block
    {
        public override string BlockId => "minecraft:prismarine";
        public override BlockState[] PossibleStates { get; }
        public PrismarineBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6540, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new PrismarineItem() };

        }
    }
}
