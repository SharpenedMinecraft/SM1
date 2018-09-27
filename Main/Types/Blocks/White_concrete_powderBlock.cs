
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:white_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public White_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8375, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_concrete_powderItem() };

        }
    }
}
