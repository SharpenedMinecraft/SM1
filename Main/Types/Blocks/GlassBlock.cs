
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class GlassBlock : Block
    {
        public override string BlockId => "minecraft:glass";
        public override BlockState[] PossibleStates { get; }
        public GlassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(212, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new GlassItem() };

        }
    }
}
