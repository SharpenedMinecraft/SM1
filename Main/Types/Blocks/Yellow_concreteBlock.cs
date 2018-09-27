
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_concreteBlock : Block
    {
        public override string BlockId => "minecraft:yellow_concrete";
        public override BlockState[] PossibleStates { get; }
        public Yellow_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8363, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_concreteItem() };

        }
    }
}
