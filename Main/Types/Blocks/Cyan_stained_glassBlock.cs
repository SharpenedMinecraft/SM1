
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:cyan_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Cyan_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3568, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_stained_glassItem() };

        }
    }
}
