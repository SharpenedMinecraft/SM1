
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:purple_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Purple_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8259, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8260, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8261, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8262, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8263, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8264, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Purple_shulker_boxItem() };

        }
    }
}
