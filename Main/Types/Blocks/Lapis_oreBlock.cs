
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lapis_oreBlock : Block
    {
        public override string BlockId => "minecraft:lapis_ore";
        public override BlockState[] PossibleStates { get; }
        public Lapis_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(213, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lapis_oreItem() };

        }
    }
}
