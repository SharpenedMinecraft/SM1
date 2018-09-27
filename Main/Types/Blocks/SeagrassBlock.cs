
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SeagrassBlock : Block
    {
        public override string BlockId => "minecraft:seagrass";
        public override BlockState[] PossibleStates { get; }
        public SeagrassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1026, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new SeagrassItem() };

        }
    }
}
