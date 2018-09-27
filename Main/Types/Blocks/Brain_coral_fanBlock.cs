
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brain_coral_fanBlock : Block
    {
        public override string BlockId => "minecraft:brain_coral_fan";
        public override BlockState[] PossibleStates { get; }
        public Brain_coral_fanBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8450, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8451, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8452, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8453, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brain_coral_fanItem() };

        }
    }
}
