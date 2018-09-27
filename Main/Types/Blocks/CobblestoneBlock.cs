
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CobblestoneBlock : Block
    {
        public override string BlockId => "minecraft:cobblestone";
        public override BlockState[] PossibleStates { get; }
        public CobblestoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(14, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new CobblestoneItem() };

        }
    }
}
