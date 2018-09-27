
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_concreteBlock : Block
    {
        public override string BlockId => "minecraft:gray_concrete";
        public override BlockState[] PossibleStates { get; }
        public Gray_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8366, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_concreteItem() };

        }
    }
}
