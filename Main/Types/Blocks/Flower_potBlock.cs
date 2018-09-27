
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Flower_potBlock : Block
    {
        public override string BlockId => "minecraft:flower_pot";
        public override BlockState[] PossibleStates { get; }
        public Flower_potBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5247, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Flower_potItem() };

        }
    }
}
