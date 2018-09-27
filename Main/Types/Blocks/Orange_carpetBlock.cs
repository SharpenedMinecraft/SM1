
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_carpetBlock : Block
    {
        public override string BlockId => "minecraft:orange_carpet";
        public override BlockState[] PossibleStates { get; }
        public Orange_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6806, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_carpetItem() };

        }
    }
}
