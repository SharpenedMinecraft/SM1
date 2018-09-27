
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Piston_headBlock : Block
    {
        public override string BlockId => "minecraft:piston_head";
        public override BlockState[] PossibleStates { get; }
        public Piston_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1041, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"short", "true"},

            {"type", "normal"},
 }),

                new BlockState(1042, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"short", "true"},

            {"type", "sticky"},
 }),

                new BlockState(1043, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"short", "false"},

            {"type", "normal"},
 }),

                new BlockState(1044, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"short", "false"},

            {"type", "sticky"},
 }),

                new BlockState(1045, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"short", "true"},

            {"type", "normal"},
 }),

                new BlockState(1046, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"short", "true"},

            {"type", "sticky"},
 }),

                new BlockState(1047, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"short", "false"},

            {"type", "normal"},
 }),

                new BlockState(1048, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"short", "false"},

            {"type", "sticky"},
 }),

                new BlockState(1049, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"short", "true"},

            {"type", "normal"},
 }),

                new BlockState(1050, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"short", "true"},

            {"type", "sticky"},
 }),

                new BlockState(1051, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"short", "false"},

            {"type", "normal"},
 }),

                new BlockState(1052, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"short", "false"},

            {"type", "sticky"},
 }),

                new BlockState(1053, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"short", "true"},

            {"type", "normal"},
 }),

                new BlockState(1054, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"short", "true"},

            {"type", "sticky"},
 }),

                new BlockState(1055, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"short", "false"},

            {"type", "normal"},
 }),

                new BlockState(1056, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"short", "false"},

            {"type", "sticky"},
 }),

                new BlockState(1057, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"short", "true"},

            {"type", "normal"},
 }),

                new BlockState(1058, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"short", "true"},

            {"type", "sticky"},
 }),

                new BlockState(1059, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"short", "false"},

            {"type", "normal"},
 }),

                new BlockState(1060, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"short", "false"},

            {"type", "sticky"},
 }),

                new BlockState(1061, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"short", "true"},

            {"type", "normal"},
 }),

                new BlockState(1062, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"short", "true"},

            {"type", "sticky"},
 }),

                new BlockState(1063, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"short", "false"},

            {"type", "normal"},
 }),

                new BlockState(1064, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"short", "false"},

            {"type", "sticky"},
 }),

            };
            State = PossibleStates[2];

            Drops = new ItemStack[] {  };

        }
    }
}
