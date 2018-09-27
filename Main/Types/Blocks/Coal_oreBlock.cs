
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Coal_oreBlock : Block
    {
        public override string BlockId => "minecraft:coal_ore";
        public override BlockState[] PossibleStates { get; }
        public Coal_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(71, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Coal_oreItem() };

        }
    }
}
