
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stripped_dark_oak_logBlock : Block
    {
        public override string BlockId => "minecraft:stripped_dark_oak_log";
        public override BlockState[] PossibleStates { get; }
        public Stripped_dark_oak_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(102, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(103, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(104, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stripped_dark_oak_logItem() };

        }
    }
}
