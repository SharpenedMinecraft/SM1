
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_blue_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:light_blue_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Light_blue_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8217, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8218, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8219, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8220, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8221, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8222, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Light_blue_shulker_boxItem() };

        }
    }
}
