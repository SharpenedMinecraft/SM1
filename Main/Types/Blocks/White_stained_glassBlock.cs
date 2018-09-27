
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:white_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public White_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3559, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_stained_glassItem() };

        }
    }
}
