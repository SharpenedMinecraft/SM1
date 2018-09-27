
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:cyan_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Cyan_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5795, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_terracottaItem() };

        }
    }
}
