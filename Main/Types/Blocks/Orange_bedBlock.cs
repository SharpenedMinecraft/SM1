
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_bedBlock : Block
    {
        public override string BlockId => "minecraft:orange_bed";
        public override BlockState[] PossibleStates { get; }
        public Orange_bedBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(746, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(747, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(748, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(749, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(750, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(751, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(752, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(753, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(754, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(755, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(756, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(757, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(758, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(759, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(760, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(761, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Orange_bedItem() };

        }
    }
}
