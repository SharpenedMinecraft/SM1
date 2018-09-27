
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_planksBlock : Block
    {
        public override string BlockId => "minecraft:acacia_planks";
        public override BlockState[] PossibleStates { get; }
        public Acacia_planksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(19, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Acacia_planksItem() };

        }
    }
}
