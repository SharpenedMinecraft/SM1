
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_woolBlock : Block
    {
        public override string BlockId => "minecraft:red_wool";
        public override BlockState[] PossibleStates { get; }
        public Red_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1079, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_woolItem() };

        }
    }
}
