
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:blue_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Blue_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8265, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8266, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8267, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8268, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8269, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8270, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Blue_shulker_boxItem() };

        }
    }
}
