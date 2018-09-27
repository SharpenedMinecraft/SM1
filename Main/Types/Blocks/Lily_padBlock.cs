
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lily_padBlock : Block
    {
        public override string BlockId => "minecraft:lily_pad";
        public override BlockState[] PossibleStates { get; }
        public Lily_padBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4476, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lily_padItem() };

        }
    }
}
