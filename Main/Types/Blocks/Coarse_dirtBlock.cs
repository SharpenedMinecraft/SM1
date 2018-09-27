
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Coarse_dirtBlock : Block
    {
        public override string BlockId => "minecraft:coarse_dirt";
        public override BlockState[] PossibleStates { get; }
        public Coarse_dirtBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(11, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Coarse_dirtItem() };

        }
    }
}
