
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_woolBlock : Block
    {
        public override string BlockId => "minecraft:purple_wool";
        public override BlockState[] PossibleStates { get; }
        public Purple_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1075, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_woolItem() };

        }
    }
}
