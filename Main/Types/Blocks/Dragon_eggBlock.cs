
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dragon_eggBlock : Block
    {
        public override string BlockId => "minecraft:dragon_egg";
        public override BlockState[] PossibleStates { get; }
        public Dragon_eggBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4617, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dragon_eggItem() };

        }
    }
}
