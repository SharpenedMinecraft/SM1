
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chiseled_sandstoneBlock : Block
    {
        public override string BlockId => "minecraft:chiseled_sandstone";
        public override BlockState[] PossibleStates { get; }
        public Chiseled_sandstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(228, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Chiseled_sandstoneItem() };

        }
    }
}
