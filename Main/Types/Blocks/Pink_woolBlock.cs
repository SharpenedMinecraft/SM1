
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_woolBlock : Block
    {
        public override string BlockId => "minecraft:pink_wool";
        public override BlockState[] PossibleStates { get; }
        public Pink_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1071, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_woolItem() };

        }
    }
}
