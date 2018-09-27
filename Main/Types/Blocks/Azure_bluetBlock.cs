
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Azure_bluetBlock : Block
    {
        public override string BlockId => "minecraft:azure_bluet";
        public override BlockState[] PossibleStates { get; }
        public Azure_bluetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1097, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Azure_bluetItem() };

        }
    }
}
