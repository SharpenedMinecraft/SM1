
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_carpetBlock : Block
    {
        public override string BlockId => "minecraft:pink_carpet";
        public override BlockState[] PossibleStates { get; }
        public Pink_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6811, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_carpetItem() };

        }
    }
}
