
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_red_mushroomBlock : Block
    {
        public override string BlockId => "minecraft:potted_red_mushroom";
        public override BlockState[] PossibleStates { get; }
        public Potted_red_mushroomBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5265, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
