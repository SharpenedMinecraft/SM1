
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:magenta_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Magenta_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3561, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_stained_glassItem() };

        }
    }
}
