
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_concreteBlock : Block
    {
        public override string BlockId => "minecraft:purple_concrete";
        public override BlockState[] PossibleStates { get; }
        public Purple_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8369, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_concreteItem() };

        }
    }
}
