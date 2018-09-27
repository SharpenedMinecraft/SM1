
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:lime_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Lime_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8229, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8230, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8231, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8232, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8233, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8234, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Lime_shulker_boxItem() };

        }
    }
}
