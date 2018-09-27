
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_woolBlock : Block
    {
        public override string BlockId => "minecraft:black_wool";
        public override BlockState[] PossibleStates { get; }
        public Black_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1080, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_woolItem() };

        }
    }
}
