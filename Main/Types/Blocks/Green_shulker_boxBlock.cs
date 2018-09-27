
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:green_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Green_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8277, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8278, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8279, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8280, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8281, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8282, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Green_shulker_boxItem() };

        }
    }
}
