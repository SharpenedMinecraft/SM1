
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Void_airBlock : Block
    {
        public override string BlockId => "minecraft:void_air";
        public override BlockState[] PossibleStates { get; }
        public Void_airBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8476, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
