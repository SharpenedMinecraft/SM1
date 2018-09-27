
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_dead_bushBlock : Block
    {
        public override string BlockId => "minecraft:potted_dead_bush";
        public override BlockState[] PossibleStates { get; }
        public Potted_dead_bushBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5267, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
