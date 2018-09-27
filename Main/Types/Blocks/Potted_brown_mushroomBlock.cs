
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Potted_brown_mushroomBlock : Block
    {
        public override string BlockId => "minecraft:potted_brown_mushroom";
        public override BlockState[] PossibleStates { get; }
        public Potted_brown_mushroomBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5266, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
