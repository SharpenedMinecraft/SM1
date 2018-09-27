
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Polished_dioriteBlock : Block
    {
        public override string BlockId => "minecraft:polished_diorite";
        public override BlockState[] PossibleStates { get; }
        public Polished_dioriteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Polished_dioriteItem() };

        }
    }
}
