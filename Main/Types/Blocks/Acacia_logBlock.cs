
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_logBlock : Block
    {
        public override string BlockId => "minecraft:acacia_log";
        public override BlockState[] PossibleStates { get; }
        public Acacia_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(84, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(85, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(86, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Acacia_logItem() };

        }
    }
}
