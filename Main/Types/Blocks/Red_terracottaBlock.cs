
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:red_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Red_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5800, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_terracottaItem() };

        }
    }
}
