
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:jungle_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Jungle_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3355, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3356, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Jungle_pressure_plateItem() };

        }
    }
}
