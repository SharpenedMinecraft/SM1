
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_woolBlock : Block
    {
        public override string BlockId => "minecraft:brown_wool";
        public override BlockState[] PossibleStates { get; }
        public Brown_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1077, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_woolItem() };

        }
    }
}
