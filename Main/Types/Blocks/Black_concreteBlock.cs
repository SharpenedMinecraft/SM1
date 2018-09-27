
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_concreteBlock : Block
    {
        public override string BlockId => "minecraft:black_concrete";
        public override BlockState[] PossibleStates { get; }
        public Black_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8374, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_concreteItem() };

        }
    }
}
