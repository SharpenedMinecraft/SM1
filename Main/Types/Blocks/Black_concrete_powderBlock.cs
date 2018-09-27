
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:black_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Black_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8390, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_concrete_powderItem() };

        }
    }
}
