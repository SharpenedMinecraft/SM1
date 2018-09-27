
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class BeaconBlock : Block
    {
        public override string BlockId => "minecraft:beacon";
        public override BlockState[] PossibleStates { get; }
        public BeaconBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5118, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new BeaconItem() };

        }
    }
}
