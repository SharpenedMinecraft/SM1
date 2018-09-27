
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Mossy_cobblestoneBlock : Block
    {
        public override string BlockId => "minecraft:mossy_cobblestone";
        public override BlockState[] PossibleStates { get; }
        public Mossy_cobblestoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1110, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Mossy_cobblestoneItem() };

        }
    }
}
