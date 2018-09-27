
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_carpetBlock : Block
    {
        public override string BlockId => "minecraft:red_carpet";
        public override BlockState[] PossibleStates { get; }
        public Red_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6819, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_carpetItem() };

        }
    }
}
