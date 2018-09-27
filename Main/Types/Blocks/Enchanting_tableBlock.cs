
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Enchanting_tableBlock : Block
    {
        public override string BlockId => "minecraft:enchanting_table";
        public override BlockState[] PossibleStates { get; }
        public Enchanting_tableBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4594, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Enchanting_tableItem() };

        }
    }
}
