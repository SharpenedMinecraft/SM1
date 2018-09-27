
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_logBlock : Block
    {
        public override string BlockId => "minecraft:spruce_log";
        public override BlockState[] PossibleStates { get; }
        public Spruce_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(75, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(76, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(77, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Spruce_logItem() };

        }
    }
}
