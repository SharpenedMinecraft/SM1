
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Fire_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:fire_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Fire_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8439, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Fire_coral_blockItem() };

        }
    }
}
