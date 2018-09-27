
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_carpetBlock : Block
    {
        public override string BlockId => "minecraft:gray_carpet";
        public override BlockState[] PossibleStates { get; }
        public Gray_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6812, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_carpetItem() };

        }
    }
}
