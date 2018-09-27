
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Tube_coral_blockBlock : Block
    {
        public override string BlockId => "minecraft:tube_coral_block";
        public override BlockState[] PossibleStates { get; }
        public Tube_coral_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8436, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Tube_coral_blockItem() };

        }
    }
}
