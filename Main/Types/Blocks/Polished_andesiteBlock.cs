
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Polished_andesiteBlock : Block
    {
        public override string BlockId => "minecraft:polished_andesite";
        public override BlockState[] PossibleStates { get; }
        public Polished_andesiteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Polished_andesiteItem() };

        }
    }
}
