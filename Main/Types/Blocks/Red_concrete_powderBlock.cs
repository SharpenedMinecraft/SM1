
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:red_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Red_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8389, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_concrete_powderItem() };

        }
    }
}
