
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_cactusBlock : Block
    {
        public override string BlockId => "minecraft:potted_cactus";
        public override BlockState[] PossibleStates { get; }
        public Potted_cactusBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5268, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
