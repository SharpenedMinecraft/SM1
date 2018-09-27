
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stripped_spruce_logBlock : Block
    {
        public override string BlockId => "minecraft:stripped_spruce_log";
        public override BlockState[] PossibleStates { get; }
        public Stripped_spruce_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(90, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(91, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(92, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stripped_spruce_logItem() };

        }
    }
}
