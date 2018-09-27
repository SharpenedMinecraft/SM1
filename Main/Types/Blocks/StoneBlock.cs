
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class StoneBlock : Block
    {
        public override string BlockId => "minecraft:stone";
        public override BlockState[] PossibleStates { get; }
        public StoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new StoneItem() };

        }
    }
}
