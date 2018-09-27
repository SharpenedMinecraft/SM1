
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Soul_sandBlock : Block
    {
        public override string BlockId => "minecraft:soul_sand";
        public override BlockState[] PossibleStates { get; }
        public Soul_sandBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3476, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Soul_sandItem() };

        }
    }
}
