
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class AndesiteBlock : Block
    {
        public override string BlockId => "minecraft:andesite";
        public override BlockState[] PossibleStates { get; }
        public AndesiteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new AndesiteItem() };

        }
    }
}
