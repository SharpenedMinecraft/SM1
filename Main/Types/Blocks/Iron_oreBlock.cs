
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Iron_oreBlock : Block
    {
        public override string BlockId => "minecraft:iron_ore";
        public override BlockState[] PossibleStates { get; }
        public Iron_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(70, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Iron_oreItem() };

        }
    }
}
