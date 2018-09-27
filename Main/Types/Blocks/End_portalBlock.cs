
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class End_portalBlock : Block
    {
        public override string BlockId => "minecraft:end_portal";
        public override BlockState[] PossibleStates { get; }
        public End_portalBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4607, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
