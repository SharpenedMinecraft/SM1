
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:brown_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Brown_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3571, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_stained_glassItem() };

        }
    }
}
