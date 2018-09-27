
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class DirtBlock : Block
    {
        public override string BlockId => "minecraft:dirt";
        public override BlockState[] PossibleStates { get; }
        public DirtBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(10, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new DirtItem() };

        }
    }
}
