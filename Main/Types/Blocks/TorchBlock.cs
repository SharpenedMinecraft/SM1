
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class TorchBlock : Block
    {
        public override string BlockId => "minecraft:torch";
        public override BlockState[] PossibleStates { get; }
        public TorchBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1112, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new TorchItem() };

        }
    }
}
