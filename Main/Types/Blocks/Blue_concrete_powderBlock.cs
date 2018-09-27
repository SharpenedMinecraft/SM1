
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:blue_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Blue_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8386, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_concrete_powderItem() };

        }
    }
}
