
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:acacia_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Acacia_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3357, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3358, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Acacia_pressure_plateItem() };

        }
    }
}
