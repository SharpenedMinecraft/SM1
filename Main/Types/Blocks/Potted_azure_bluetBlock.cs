
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_azure_bluetBlock : Block
    {
        public override string BlockId => "minecraft:potted_azure_bluet";
        public override BlockState[] PossibleStates { get; }
        public Potted_azure_bluetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5259, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
