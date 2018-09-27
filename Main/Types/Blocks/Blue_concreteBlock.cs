
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_concreteBlock : Block
    {
        public override string BlockId => "minecraft:blue_concrete";
        public override BlockState[] PossibleStates { get; }
        public Blue_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8370, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_concreteItem() };

        }
    }
}
