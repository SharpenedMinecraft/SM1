
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gold_oreBlock : Block
    {
        public override string BlockId => "minecraft:gold_ore";
        public override BlockState[] PossibleStates { get; }
        public Gold_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(69, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gold_oreItem() };

        }
    }
}
