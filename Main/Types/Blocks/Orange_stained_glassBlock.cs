
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:orange_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Orange_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3560, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_stained_glassItem() };

        }
    }
}
