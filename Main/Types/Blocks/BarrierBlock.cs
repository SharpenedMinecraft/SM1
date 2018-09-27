
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class BarrierBlock : Block
    {
        public override string BlockId => "minecraft:barrier";
        public override BlockState[] PossibleStates { get; }
        public BarrierBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6475, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new BarrierItem() };

        }
    }
}
