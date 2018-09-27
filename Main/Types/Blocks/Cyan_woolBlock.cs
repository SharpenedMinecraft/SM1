
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_woolBlock : Block
    {
        public override string BlockId => "minecraft:cyan_wool";
        public override BlockState[] PossibleStates { get; }
        public Cyan_woolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1074, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_woolItem() };

        }
    }
}
