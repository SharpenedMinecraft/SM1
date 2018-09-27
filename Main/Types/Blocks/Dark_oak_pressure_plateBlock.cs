
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3359, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3360, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Dark_oak_pressure_plateItem() };

        }
    }
}
