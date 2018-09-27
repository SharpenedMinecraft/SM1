
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Infested_stoneBlock : Block
    {
        public override string BlockId => "minecraft:infested_stone";
        public override BlockState[] PossibleStates { get; }
        public Infested_stoneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3959, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Infested_stoneItem() };

        }
    }
}
