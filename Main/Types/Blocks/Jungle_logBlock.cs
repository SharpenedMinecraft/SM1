
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_logBlock : Block
    {
        public override string BlockId => "minecraft:jungle_log";
        public override BlockState[] PossibleStates { get; }
        public Jungle_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(81, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(82, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(83, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Jungle_logItem() };

        }
    }
}
