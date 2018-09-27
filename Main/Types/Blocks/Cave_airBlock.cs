
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cave_airBlock : Block
    {
        public override string BlockId => "minecraft:cave_air";
        public override BlockState[] PossibleStates { get; }
        public Cave_airBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8477, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
