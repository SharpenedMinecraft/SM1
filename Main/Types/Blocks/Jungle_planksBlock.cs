
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_planksBlock : Block
    {
        public override string BlockId => "minecraft:jungle_planks";
        public override BlockState[] PossibleStates { get; }
        public Jungle_planksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(18, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Jungle_planksItem() };

        }
    }
}
