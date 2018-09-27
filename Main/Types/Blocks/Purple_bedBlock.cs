
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_bedBlock : Block
    {
        public override string BlockId => "minecraft:purple_bed";
        public override BlockState[] PossibleStates { get; }
        public Purple_bedBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(890, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(891, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(892, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(893, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(894, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(895, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(896, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(897, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(898, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(899, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(900, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(901, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(902, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(903, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(904, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(905, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Purple_bedItem() };

        }
    }
}
