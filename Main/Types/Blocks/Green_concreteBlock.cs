
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_concreteBlock : Block
    {
        public override string BlockId => "minecraft:green_concrete";
        public override BlockState[] PossibleStates { get; }
        public Green_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8372, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_concreteItem() };

        }
    }
}
