
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:green_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Green_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3572, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_stained_glassItem() };

        }
    }
}
