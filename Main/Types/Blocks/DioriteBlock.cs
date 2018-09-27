
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class DioriteBlock : Block
    {
        public override string BlockId => "minecraft:diorite";
        public override BlockState[] PossibleStates { get; }
        public DioriteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new DioriteItem() };

        }
    }
}
