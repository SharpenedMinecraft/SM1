
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Packed_iceBlock : Block
    {
        public override string BlockId => "minecraft:packed_ice";
        public override BlockState[] PossibleStates { get; }
        public Packed_iceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6823, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Packed_iceItem() };

        }
    }
}
