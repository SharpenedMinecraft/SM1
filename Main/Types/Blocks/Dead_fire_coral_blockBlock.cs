
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dead_fire_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:dead_fire_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Dead_fire_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8434, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dead_fire_coral_blockItem() };

        }
    }
}
