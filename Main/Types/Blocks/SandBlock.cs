
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SandBlock : Block
    {
        public override string BlockId => "minecraft:sand";
        public override BlockState[] PossibleStates { get; }
        public SandBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(66, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new SandItem() };

        }
    }
}
