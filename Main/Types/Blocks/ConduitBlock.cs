
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class ConduitBlock : Block
    {
        public override string BlockId => "minecraft:conduit";
        public override BlockState[] PossibleStates { get; }
        public ConduitBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8475, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new ConduitItem() };

        }
    }
}
