
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_logBlock : Block
    {
        public override string BlockId => "minecraft:birch_log";
        public override BlockState[] PossibleStates { get; }
        public Birch_logBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(78, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(79, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(80, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Birch_logItem() };

        }
    }
}
