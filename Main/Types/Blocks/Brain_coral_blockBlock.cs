
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brain_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:brain_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Brain_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8437, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brain_coral_blockItem() };

        }
    }
}
