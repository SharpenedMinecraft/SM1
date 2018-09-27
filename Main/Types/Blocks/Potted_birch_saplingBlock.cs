
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_birch_saplingBlock : Block
    {
        public override string BlockId => "minecraft:potted_birch_sapling";
        public override BlockState[] PossibleStates { get; }
        public Potted_birch_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5250, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
