
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:gray_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Gray_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3566, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_stained_glassItem() };

        }
    }
}
