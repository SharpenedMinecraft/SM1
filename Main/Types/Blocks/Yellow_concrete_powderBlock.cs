
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:yellow_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Yellow_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8379, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_concrete_powderItem() };

        }
    }
}
