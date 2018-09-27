
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class GlowstoneBlock : Block
    {
        public override string BlockId => "minecraft:glowstone";
        public override BlockState[] PossibleStates { get; }
        public GlowstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3477, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new GlowstoneItem() };

        }
    }
}
