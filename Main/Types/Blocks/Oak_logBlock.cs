
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_logBlock : Block
    {
        public override string BlockId => "minecraft:oak_log";
        public override BlockState[] PossibleStates { get; }
        public Oak_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(72, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(73, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(74, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Oak_logItem() };

        }
    }
}
