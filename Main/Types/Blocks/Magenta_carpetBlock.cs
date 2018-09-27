
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_carpetBlock : Block
    {
        public override string BlockId => "minecraft:magenta_carpet";
        public override BlockState[] PossibleStates { get; }
        public Magenta_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6807, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_carpetItem() };

        }
    }
}
