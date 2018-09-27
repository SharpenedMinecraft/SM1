
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_planksBlock : Block
    {
        public override string BlockId => "minecraft:spruce_planks";
        public override BlockState[] PossibleStates { get; }
        public Spruce_planksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(16, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Spruce_planksItem() };

        }
    }
}
