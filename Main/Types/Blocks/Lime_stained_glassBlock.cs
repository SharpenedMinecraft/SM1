
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:lime_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Lime_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3564, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_stained_glassItem() };

        }
    }
}
