
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_stained_glassBlock : Block
    {
        public override string BlockId => "minecraft:red_stained_glass";
        public override BlockState[] PossibleStates { get; }
        public Red_stained_glassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3573, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_stained_glassItem() };

        }
    }
}
