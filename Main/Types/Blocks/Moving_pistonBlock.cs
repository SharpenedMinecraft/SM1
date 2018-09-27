
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Moving_pistonBlock : Block
    {
        public override string BlockId => "minecraft:moving_piston";
        public override BlockState[] PossibleStates { get; }
        public Moving_pistonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1081, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "normal"},
 }),

                new BlockState(1082, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "sticky"},
 }),

                new BlockState(1083, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "normal"},
 }),

                new BlockState(1084, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "sticky"},
 }),

                new BlockState(1085, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "normal"},
 }),

                new BlockState(1086, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "sticky"},
 }),

                new BlockState(1087, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "normal"},
 }),

                new BlockState(1088, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "sticky"},
 }),

                new BlockState(1089, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"type", "normal"},
 }),

                new BlockState(1090, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"type", "sticky"},
 }),

                new BlockState(1091, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"type", "normal"},
 }),

                new BlockState(1092, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"type", "sticky"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
