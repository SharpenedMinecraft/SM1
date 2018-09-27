
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_concreteBlock : Block
    {
        public override string BlockId => "minecraft:red_concrete";
        public override BlockState[] PossibleStates { get; }
        public Red_concreteBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8373, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_concreteItem() };

        }
    }
}
