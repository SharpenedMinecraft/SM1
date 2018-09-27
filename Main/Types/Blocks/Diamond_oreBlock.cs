
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Diamond_oreBlock : Block
    {
        public override string BlockId => "minecraft:diamond_ore";
        public override BlockState[] PossibleStates { get; }
        public Diamond_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3030, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Diamond_oreItem() };

        }
    }
}
