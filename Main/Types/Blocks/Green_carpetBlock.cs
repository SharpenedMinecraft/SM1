
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_carpetBlock : Block
    {
        public override string BlockId => "minecraft:green_carpet";
        public override BlockState[] PossibleStates { get; }
        public Green_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6818, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_carpetItem() };

        }
    }
}
