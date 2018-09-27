
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_bedBlock : Block
    {
        public override string BlockId => "minecraft:white_bed";
        public override BlockState[] PossibleStates { get; }
        public White_bedBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(730, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(731, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(732, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(733, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(734, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(735, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(736, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(737, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(738, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(739, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(740, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(741, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(742, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(743, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(744, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(745, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new White_bedItem() };

        }
    }
}
