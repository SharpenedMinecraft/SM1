
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_woolBlock : Block
    {
        public override string BlockId => "minecraft:gray_wool";
        public override BlockState[] PossibleStates { get; }
        public Gray_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1072, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_woolItem() };

        }
    }
}
