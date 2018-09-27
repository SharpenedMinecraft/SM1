
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class ClayBlock : Block
    {
        public override string BlockId => "minecraft:clay";
        public override BlockState[] PossibleStates { get; }
        public ClayBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3423, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new ClayItem() };

        }
    }
}
