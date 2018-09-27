
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stripped_oak_logBlock : Block
    {
        public override string BlockId => "minecraft:stripped_oak_log";
        public override BlockState[] PossibleStates { get; }
        public Stripped_oak_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(105, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(106, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(107, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stripped_oak_logItem() };

        }
    }
}
