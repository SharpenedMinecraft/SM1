
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Stripped_acacia_logBlock : Block
    {
        public override string BlockId => "minecraft:stripped_acacia_log";
        public override BlockState[] PossibleStates { get; }
        public Stripped_acacia_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(99, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(100, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(101, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Stripped_acacia_logItem() };

        }
    }
}
