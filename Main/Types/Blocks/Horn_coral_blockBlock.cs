
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Horn_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:horn_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Horn_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8440, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Horn_coral_blockItem() };

        }
    }
}
