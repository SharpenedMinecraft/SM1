
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_carpetBlock : Block
    {
        public override string BlockId => "minecraft:yellow_carpet";
        public override BlockState[] PossibleStates { get; }
        public Yellow_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6809, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_carpetItem() };

        }
    }
}
