
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SpongeBlock : Block
    {
        public override string BlockId => "minecraft:sponge";
        public override BlockState[] PossibleStates { get; }
        public SpongeBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(210, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new SpongeItem() };

        }
    }
}
