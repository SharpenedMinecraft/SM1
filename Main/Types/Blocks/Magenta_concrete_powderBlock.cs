
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:magenta_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Magenta_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8377, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_concrete_powderItem() };

        }
    }
}
