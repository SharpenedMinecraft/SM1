
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Nether_quartz_oreBlock : Block
    {
        public override string BlockId => "minecraft:nether_quartz_ore";
        public override BlockState[] PossibleStates { get; }
        public Nether_quartz_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5666, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Nether_quartz_oreItem() };

        }
    }
}
