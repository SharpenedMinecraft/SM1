
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SandstoneBlock : Block
    {
        public override string BlockId => "minecraft:sandstone";
        public override BlockState[] PossibleStates { get; }
        public SandstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(227, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new SandstoneItem() };

        }
    }
}
