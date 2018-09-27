
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_concreteBlock : Block
    {
        public override string BlockId => "minecraft:cyan_concrete";
        public override BlockState[] PossibleStates { get; }
        public Cyan_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8368, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_concreteItem() };

        }
    }
}
