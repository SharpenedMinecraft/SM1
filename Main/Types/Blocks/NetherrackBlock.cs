
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class NetherrackBlock : Block
    {
        public override string BlockId => "minecraft:netherrack";
        public override BlockState[] PossibleStates { get; }
        public NetherrackBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3475, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new NetherrackItem() };

        }
    }
}
