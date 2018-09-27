
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:white_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public White_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8199, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8200, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8201, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8202, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8203, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8204, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new White_shulker_boxItem() };

        }
    }
}
