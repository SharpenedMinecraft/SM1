
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_concreteBlock : Block
    {
        public override string BlockId => "minecraft:white_concrete";
        public override BlockState[] PossibleStates { get; }
        public White_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8359, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_concreteItem() };

        }
    }
}
