
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_orchidBlock : Block
    {
        public override string BlockId => "minecraft:blue_orchid";
        public override BlockState[] PossibleStates { get; }
        public Blue_orchidBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1095, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_orchidItem() };

        }
    }
}
