
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:purple_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Purple_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8385, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_concrete_powderItem() };

        }
    }
}
