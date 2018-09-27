
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_concreteBlock : Block
    {
        public override string BlockId => "minecraft:orange_concrete";
        public override BlockState[] PossibleStates { get; }
        public Orange_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8360, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_concreteItem() };

        }
    }
}
