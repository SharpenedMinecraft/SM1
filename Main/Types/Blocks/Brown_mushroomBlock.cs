
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_mushroomBlock : Block
    {
        public override string BlockId => "minecraft:brown_mushroom";
        public override BlockState[] PossibleStates { get; }
        public Brown_mushroomBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1103, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_mushroomItem() };

        }
    }
}
