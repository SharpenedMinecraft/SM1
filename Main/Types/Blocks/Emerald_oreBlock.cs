
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Emerald_oreBlock : Block
    {
        public override string BlockId => "minecraft:emerald_ore";
        public override BlockState[] PossibleStates { get; }
        public Emerald_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4712, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Emerald_oreItem() };

        }
    }
}
