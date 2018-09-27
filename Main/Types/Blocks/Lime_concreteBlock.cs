
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_concreteBlock : Block
    {
        public override string BlockId => "minecraft:lime_concrete";
        public override BlockState[] PossibleStates { get; }
        public Lime_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8364, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_concreteItem() };

        }
    }
}
