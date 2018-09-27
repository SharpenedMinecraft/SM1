
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Grass_pathBlock : Block
    {
        public override string BlockId => "minecraft:grass_path";
        public override BlockState[] PossibleStates { get; }
        public Grass_pathBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8144, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Grass_pathItem() };

        }
    }
}
