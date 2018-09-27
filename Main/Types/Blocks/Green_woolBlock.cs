
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_woolBlock : Block
    {
        public override string BlockId => "minecraft:green_wool";
        public override BlockState[] PossibleStates { get; }
        public Green_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1078, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_woolItem() };

        }
    }
}
