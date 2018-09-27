
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_carpetBlock : Block
    {
        public override string BlockId => "minecraft:purple_carpet";
        public override BlockState[] PossibleStates { get; }
        public Purple_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6815, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_carpetItem() };

        }
    }
}
