
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Fire_coral_fanBlock : Block
    {
        public override string BlockId => "minecraft:fire_coral_fan";
        public override BlockState[] PossibleStates { get; }
        public Fire_coral_fanBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8458, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8459, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8460, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8461, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Fire_coral_fanItem() };

        }
    }
}
