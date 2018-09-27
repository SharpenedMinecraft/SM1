
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Bubble_coral_fanBlock : Block
    {
        public override string BlockId => "minecraft:bubble_coral_fan";
        public override BlockState[] PossibleStates { get; }
        public Bubble_coral_fanBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8454, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8455, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8456, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8457, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Bubble_coral_fanItem() };

        }
    }
}
