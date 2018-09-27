
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PistonBlock : Block
    {
        public override string BlockId => "minecraft:piston";
        public override BlockState[] PossibleStates { get; }
        public PistonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1029, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "north"},
 }),

                new BlockState(1030, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "east"},
 }),

                new BlockState(1031, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "south"},
 }),

                new BlockState(1032, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "west"},
 }),

                new BlockState(1033, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "up"},
 }),

                new BlockState(1034, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "down"},
 }),

                new BlockState(1035, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "north"},
 }),

                new BlockState(1036, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "east"},
 }),

                new BlockState(1037, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "south"},
 }),

                new BlockState(1038, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "west"},
 }),

                new BlockState(1039, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "up"},
 }),

                new BlockState(1040, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "down"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new PistonItem() };

        }
    }
}
