
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:brown_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Brown_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8271, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8272, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8273, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8274, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8275, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8276, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Brown_shulker_boxItem() };

        }
    }
}
