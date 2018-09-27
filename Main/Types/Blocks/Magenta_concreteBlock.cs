
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_concreteBlock : Block
    {
        public override string BlockId => "minecraft:magenta_concrete";
        public override BlockState[] PossibleStates { get; }
        public Magenta_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8361, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_concreteItem() };

        }
    }
}
