
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:magenta_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Magenta_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8211, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8212, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8213, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8214, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8215, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8216, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Magenta_shulker_boxItem() };

        }
    }
}
