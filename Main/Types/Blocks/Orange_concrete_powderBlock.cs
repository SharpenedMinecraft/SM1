
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:orange_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Orange_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8376, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_concrete_powderItem() };

        }
    }
}
