
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dead_tube_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:dead_tube_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Dead_tube_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8431, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dead_tube_coral_blockItem() };

        }
    }
}
