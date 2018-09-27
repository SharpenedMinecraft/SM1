
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lapis_blockBlock : Block
    {
        public override string BlockId => "minecraft:lapis_block";
        public override BlockState[] PossibleStates { get; }
        public Lapis_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(214, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lapis_blockItem() };

        }
    }
}
