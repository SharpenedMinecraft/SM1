
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_carpetBlock : Block
    {
        public override string BlockId => "minecraft:black_carpet";
        public override BlockState[] PossibleStates { get; }
        public Black_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6820, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_carpetItem() };

        }
    }
}
