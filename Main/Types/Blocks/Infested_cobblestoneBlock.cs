
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Infested_cobblestoneBlock : Block
    {
        public override string BlockId => "minecraft:infested_cobblestone";
        public override BlockState[] PossibleStates { get; }
        public Infested_cobblestoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3960, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Infested_cobblestoneItem() };

        }
    }
}
