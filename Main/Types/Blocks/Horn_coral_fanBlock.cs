
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Horn_coral_fanBlock : Block
    {
        public override string BlockId => "minecraft:horn_coral_fan";
        public override BlockState[] PossibleStates { get; }
        public Horn_coral_fanBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8462, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8463, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8464, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8465, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Horn_coral_fanItem() };

        }
    }
}
