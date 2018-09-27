
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8247, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8248, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8249, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8250, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8251, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8252, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Light_gray_shulker_boxItem() };

        }
    }
}
