
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cut_sandstoneBlock : Block
    {
        public override string BlockId => "minecraft:cut_sandstone";
        public override BlockState[] PossibleStates { get; }
        public Cut_sandstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(229, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cut_sandstoneItem() };

        }
    }
}
