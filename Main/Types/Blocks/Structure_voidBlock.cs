
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Structure_voidBlock : Block
    {
        public override string BlockId => "minecraft:structure_void";
        public override BlockState[] PossibleStates { get; }
        public Structure_voidBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8180, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Structure_voidItem() };

        }
    }
}
