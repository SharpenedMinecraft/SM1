
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_woolBlock : Block
    {
        public override string BlockId => "minecraft:white_wool";
        public override BlockState[] PossibleStates { get; }
        public White_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1065, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_woolItem() };

        }
    }
}
