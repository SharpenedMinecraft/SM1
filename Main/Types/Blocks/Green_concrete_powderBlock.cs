
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:green_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Green_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8388, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_concrete_powderItem() };

        }
    }
}
