
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_planksBlock : Block
    {
        public override string BlockId => "minecraft:oak_planks";
        public override BlockState[] PossibleStates { get; }
        public Oak_planksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(15, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Oak_planksItem() };

        }
    }
}
