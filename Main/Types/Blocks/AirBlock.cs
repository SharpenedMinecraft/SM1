
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class AirBlock : Block
    {
        public override string BlockId => "minecraft:air";
        public override BlockState[] PossibleStates { get; }
        public AirBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(0, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new AirItem() };

        }
    }
}
