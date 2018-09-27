
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_carpetBlock : Block
    {
        public override string BlockId => "minecraft:brown_carpet";
        public override BlockState[] PossibleStates { get; }
        public Brown_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6817, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_carpetItem() };

        }
    }
}
