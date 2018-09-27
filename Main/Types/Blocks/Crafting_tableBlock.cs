
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Crafting_tableBlock : Block
    {
        public override string BlockId => "minecraft:crafting_table";
        public override BlockState[] PossibleStates { get; }
        public Crafting_tableBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3032, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Crafting_tableItem() };

        }
    }
}
