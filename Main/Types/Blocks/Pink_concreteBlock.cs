
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_concreteBlock : Block
    {
        public override string BlockId => "minecraft:pink_concrete";
        public override BlockState[] PossibleStates { get; }
        public Pink_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8365, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_concreteItem() };

        }
    }
}
