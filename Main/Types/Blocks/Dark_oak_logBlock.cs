
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_logBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_log";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(87, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(88, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(89, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Dark_oak_logItem() };

        }
    }
}
