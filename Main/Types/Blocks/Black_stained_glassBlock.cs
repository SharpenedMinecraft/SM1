
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:black_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Black_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3574, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_stained_glassItem() };

        }
    }
}
