
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:red_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Red_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8283, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8284, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8285, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8286, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8287, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8288, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Red_shulker_boxItem() };

        }
    }
}
