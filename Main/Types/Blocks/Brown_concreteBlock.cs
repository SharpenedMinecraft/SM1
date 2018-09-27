
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_concreteBlock : Block
    {
        public override string BlockId => "minecraft:brown_concrete";
        public override BlockState[] PossibleStates { get; }
        public Brown_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8371, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_concreteItem() };

        }
    }
}
