
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Kelp_plantBlock : Block
    {
        public override string BlockId => "minecraft:kelp_plant";
        public override BlockState[] PossibleStates { get; }
        public Kelp_plantBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8391, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
