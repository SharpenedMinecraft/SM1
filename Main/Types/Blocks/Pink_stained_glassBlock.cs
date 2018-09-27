
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:pink_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Pink_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3565, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_stained_glassItem() };

        }
    }
}
