
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:spruce_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Spruce_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3351, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3352, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Spruce_pressure_plateItem() };

        }
    }
}
