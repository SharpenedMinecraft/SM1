
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_sandstoneBlock : Block
    {
        public override string BlockId => "minecraft:red_sandstone";
        public override BlockState[] PossibleStates { get; }
        public Red_sandstoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7156, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_sandstoneItem() };

        }
    }
}
