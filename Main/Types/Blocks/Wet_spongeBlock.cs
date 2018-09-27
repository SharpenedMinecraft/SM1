
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Wet_spongeBlock : Block
    {
        public override string BlockId => "minecraft:wet_sponge";
        public override BlockState[] PossibleStates { get; }
        public Wet_spongeBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(211, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Wet_spongeItem() };

        }
    }
}
