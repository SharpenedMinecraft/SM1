
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_woolBlock : Block
    {
        public override string BlockId => "minecraft:magenta_wool";
        public override BlockState[] PossibleStates { get; }
        public Magenta_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1067, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_woolItem() };

        }
    }
}
