
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_woolBlock : Block
    {
        public override string BlockId => "minecraft:blue_wool";
        public override BlockState[] PossibleStates { get; }
        public Blue_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1076, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_woolItem() };

        }
    }
}
