
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:pink_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Pink_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8381, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_concrete_powderItem() };

        }
    }
}
