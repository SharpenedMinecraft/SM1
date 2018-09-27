
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_bedBlock : Block
    {
        public override string BlockId => "minecraft:lime_bed";
        public override BlockState[] PossibleStates { get; }
        public Lime_bedBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(810, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(811, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(812, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(813, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(814, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(815, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(816, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(817, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(818, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(819, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(820, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(821, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(822, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(823, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(824, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(825, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Lime_bedItem() };

        }
    }
}
