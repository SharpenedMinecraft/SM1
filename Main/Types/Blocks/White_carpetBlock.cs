
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_carpetBlock : Block
    {
        public override string BlockId => "minecraft:white_carpet";
        public override BlockState[] PossibleStates { get; }
        public White_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6805, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_carpetItem() };

        }
    }
}
