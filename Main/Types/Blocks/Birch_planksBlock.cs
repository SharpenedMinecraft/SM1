
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_planksBlock : Block
    {
        public override string BlockId => "minecraft:birch_planks";
        public override BlockState[] PossibleStates { get; }
        public Birch_planksBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(17, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Birch_planksItem() };

        }
    }
}
