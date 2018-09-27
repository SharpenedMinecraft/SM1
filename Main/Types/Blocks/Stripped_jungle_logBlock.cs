
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stripped_jungle_logBlock : Block
    {
        public override string BlockId => "minecraft:stripped_jungle_log";
        public override BlockState[] PossibleStates { get; }
        public Stripped_jungle_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(96, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(97, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(98, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stripped_jungle_logItem() };

        }
    }
}
