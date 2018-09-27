
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_woolBlock : Block
    {
        public override string BlockId => "minecraft:lime_wool";
        public override BlockState[] PossibleStates { get; }
        public Lime_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1070, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_woolItem() };

        }
    }
}
