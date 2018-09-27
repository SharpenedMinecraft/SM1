
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cut_red_sandstoneBlock : Block
    {
        public override string BlockId => "minecraft:cut_red_sandstone";
        public override BlockState[] PossibleStates { get; }
        public Cut_red_sandstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7158, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cut_red_sandstoneItem() };

        }
    }
}
