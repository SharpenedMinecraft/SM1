
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_concrete_powderBlock : Block
    {
        public override string BlockId => "minecraft:cyan_concrete_powder";
        public override BlockState[] PossibleStates { get; }
        public Cyan_concrete_powderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8384, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_concrete_powderItem() };

        }
    }
}
