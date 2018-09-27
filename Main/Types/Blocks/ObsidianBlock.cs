
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class ObsidianBlock : Block
    {
        public override string BlockId => "minecraft:obsidian";
        public override BlockState[] PossibleStates { get; }
        public ObsidianBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1111, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new ObsidianItem() };

        }
    }
}
