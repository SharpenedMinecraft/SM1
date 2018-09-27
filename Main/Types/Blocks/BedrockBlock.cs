
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class BedrockBlock : Block
    {
        public override string BlockId => "minecraft:bedrock";
        public override BlockState[] PossibleStates { get; }
        public BedrockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(33, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new BedrockItem() };

        }
    }
}
