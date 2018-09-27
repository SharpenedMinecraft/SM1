
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stripped_birch_logBlock : Block
    {
        public override string BlockId => "minecraft:stripped_birch_log";
        public override BlockState[] PossibleStates { get; }
        public Stripped_birch_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(93, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(94, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(95, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stripped_birch_logItem() };

        }
    }
}
