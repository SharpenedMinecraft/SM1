
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_jungle_saplingBlock : Block
    {
        public override string BlockId => "minecraft:potted_jungle_sapling";
        public override BlockState[] PossibleStates { get; }
        public Potted_jungle_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5251, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
