
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class End_stoneBlock : Block
    {
        public override string BlockId => "minecraft:end_stone";
        public override BlockState[] PossibleStates { get; }
        public End_stoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4616, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new End_stoneItem() };

        }
    }
}
