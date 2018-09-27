
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:lime_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Lime_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5791, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_terracottaItem() };

        }
    }
}
