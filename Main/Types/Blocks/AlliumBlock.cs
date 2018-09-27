
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class AlliumBlock : Block
    {
        public override string BlockId => "minecraft:allium";
        public override BlockState[] PossibleStates { get; }
        public AlliumBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1096, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new AlliumItem() };

        }
    }
}
