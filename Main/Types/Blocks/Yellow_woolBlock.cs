
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_woolBlock : Block
    {
        public override string BlockId => "minecraft:yellow_wool";
        public override BlockState[] PossibleStates { get; }
        public Yellow_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1069, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_woolItem() };

        }
    }
}
