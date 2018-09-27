
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class IceBlock : Block
    {
        public override string BlockId => "minecraft:ice";
        public override BlockState[] PossibleStates { get; }
        public IceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3405, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new IceItem() };

        }
    }
}
