
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:birch_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Birch_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3353, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3354, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Birch_pressure_plateItem() };

        }
    }
}
