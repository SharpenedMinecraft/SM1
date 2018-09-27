
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:blue_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Blue_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3570, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_stained_glassItem() };

        }
    }
}
