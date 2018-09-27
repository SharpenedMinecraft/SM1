
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_fernBlock : Block
    {
        public override string BlockId => "minecraft:potted_fern";
        public override BlockState[] PossibleStates { get; }
        public Potted_fernBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5254, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
