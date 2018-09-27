
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_mushroomBlock : Block
    {
        public override string BlockId => "minecraft:red_mushroom";
        public override BlockState[] PossibleStates { get; }
        public Red_mushroomBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1104, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_mushroomItem() };

        }
    }
}
