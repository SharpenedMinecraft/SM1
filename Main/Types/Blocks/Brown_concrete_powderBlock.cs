
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:brown_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Brown_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8387, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_concrete_powderItem() };

        }
    }
}
