
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_blue_orchidBlock : Block
    {
        public override string BlockId => "minecraft:potted_blue_orchid";
        public override BlockState[] PossibleStates { get; }
        public Potted_blue_orchidBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5257, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
