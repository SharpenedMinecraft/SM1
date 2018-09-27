
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CobwebBlock : Block
    {
        public override string BlockId => "minecraft:cobweb";
        public override BlockState[] PossibleStates { get; }
        public CobwebBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1022, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new CobwebItem() };

        }
    }
}
