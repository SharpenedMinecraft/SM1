
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_sandBlock : Block
    {
        public override string BlockId => "minecraft:red_sand";
        public override BlockState[] PossibleStates { get; }
        public Red_sandBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(67, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_sandItem() };

        }
    }
}
