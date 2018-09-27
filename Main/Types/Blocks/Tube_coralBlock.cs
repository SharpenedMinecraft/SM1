
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Tube_coralBlock : Block
    {
        public override string BlockId => "minecraft:tube_coral";
        public override BlockState[] PossibleStates { get; }
        public Tube_coralBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8441, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Tube_coralItem() };

        }
    }
}
