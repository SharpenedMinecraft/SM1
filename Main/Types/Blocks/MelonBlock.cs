
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class MelonBlock : Block
    {
        public override string BlockId => "minecraft:melon";
        public override BlockState[] PossibleStates { get; }
        public MelonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4225, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new MelonItem() };

        }
    }
}
