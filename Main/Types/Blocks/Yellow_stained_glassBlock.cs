
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:yellow_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Yellow_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3563, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_stained_glassItem() };

        }
    }
}
