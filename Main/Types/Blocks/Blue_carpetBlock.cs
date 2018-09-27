
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_carpetBlock : Block
    {
        public override string BlockId => "minecraft:blue_carpet";
        public override BlockState[] PossibleStates { get; }
        public Blue_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6816, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_carpetItem() };

        }
    }
}
