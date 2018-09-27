
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stone_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:stone_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Stone_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3283, new Dictionary<string, string>
                { 
            {"powered", "true"},
 }),

                new BlockState(3284, new Dictionary<string, string>
                { 
            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stone_pressure_plateItem() };

        }
    }
}
