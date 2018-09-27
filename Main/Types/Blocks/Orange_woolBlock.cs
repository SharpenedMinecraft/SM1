
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_woolBlock : Block
    {
        public override string BlockId => "minecraft:orange_wool";
        public override BlockState[] PossibleStates { get; }
        public Orange_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1066, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_woolItem() };

        }
    }
}
