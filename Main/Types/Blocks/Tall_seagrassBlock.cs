
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Tall_seagrassBlock : Block
    {
        public override string BlockId => "minecraft:tall_seagrass";
        public override BlockState[] PossibleStates { get; }
        public Tall_seagrassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1027, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(1028, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] {  };

        }
    }
}
