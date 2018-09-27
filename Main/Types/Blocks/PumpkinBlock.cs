
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PumpkinBlock : Block
    {
        public override string BlockId => "minecraft:pumpkin";
        public override BlockState[] PossibleStates { get; }
        public PumpkinBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3474, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new PumpkinItem() };

        }
    }
}
