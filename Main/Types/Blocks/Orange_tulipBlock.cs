
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_tulipBlock : Block
    {
        public override string BlockId => "minecraft:orange_tulip";
        public override BlockState[] PossibleStates { get; }
        public Orange_tulipBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1099, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_tulipItem() };

        }
    }
}
