
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Sticky_pistonBlock : Block
    {
        public override string BlockId => "minecraft:sticky_piston";
        public override BlockState[] PossibleStates { get; }
        public Sticky_pistonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1010, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "north"},
 }),

                new BlockState(1011, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "east"},
 }),

                new BlockState(1012, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "south"},
 }),

                new BlockState(1013, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "west"},
 }),

                new BlockState(1014, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "up"},
 }),

                new BlockState(1015, new Dictionary<string, string>
                { 
            {"extended", "true"},

            {"facing", "down"},
 }),

                new BlockState(1016, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "north"},
 }),

                new BlockState(1017, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "east"},
 }),

                new BlockState(1018, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "south"},
 }),

                new BlockState(1019, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "west"},
 }),

                new BlockState(1020, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "up"},
 }),

                new BlockState(1021, new Dictionary<string, string>
                { 
            {"extended", "false"},

            {"facing", "down"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Sticky_pistonItem() };

        }
    }
}
