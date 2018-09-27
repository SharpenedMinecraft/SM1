
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class End_gatewayBlock : Block
    {
        public override string BlockId => "minecraft:end_gateway";
        public override BlockState[] PossibleStates { get; }
        public End_gatewayBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8145, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
