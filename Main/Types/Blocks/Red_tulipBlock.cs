
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_tulipBlock : Block
    {
        public override string BlockId => "minecraft:red_tulip";
        public override BlockState[] PossibleStates { get; }
        public Red_tulipBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1098, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_tulipItem() };

        }
    }
}
