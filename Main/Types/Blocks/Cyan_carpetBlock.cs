
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_carpetBlock : Block
    {
        public override string BlockId => "minecraft:cyan_carpet";
        public override BlockState[] PossibleStates { get; }
        public Cyan_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6814, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_carpetItem() };

        }
    }
}
