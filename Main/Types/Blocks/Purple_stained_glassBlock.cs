
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:purple_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Purple_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3569, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_stained_glassItem() };

        }
    }
}
