
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Bubble_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:bubble_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Bubble_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8438, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Bubble_coral_blockItem() };

        }
    }
}
