
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:oak_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Oak_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3349, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3350, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Oak_pressure_plateItem() };

        }
    }
}
