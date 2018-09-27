
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:lime_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Lime_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8380, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_concrete_powderItem() };

        }
    }
}
