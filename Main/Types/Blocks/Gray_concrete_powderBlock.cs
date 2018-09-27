
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:gray_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Gray_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8382, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_concrete_powderItem() };

        }
    }
}
