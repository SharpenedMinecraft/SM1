
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class DropperBlock : Block
    {
        public override string BlockId => "minecraft:dropper";
        public override BlockState[] PossibleStates { get; }
        public DropperBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5774, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"triggered", "true"},
 }),

                new BlockState(5775, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"triggered", "false"},
 }),

                new BlockState(5776, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"triggered", "true"},
 }),

                new BlockState(5777, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"triggered", "false"},
 }),

                new BlockState(5778, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"triggered", "true"},
 }),

                new BlockState(5779, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"triggered", "false"},
 }),

                new BlockState(5780, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"triggered", "true"},
 }),

                new BlockState(5781, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"triggered", "false"},
 }),

                new BlockState(5782, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"triggered", "true"},
 }),

                new BlockState(5783, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"triggered", "false"},
 }),

                new BlockState(5784, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"triggered", "true"},
 }),

                new BlockState(5785, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"triggered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new DropperItem() };

        }
    }
}
