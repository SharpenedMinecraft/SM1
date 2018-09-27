
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_bedBlock : Block
    {
        public override string BlockId => "minecraft:cyan_bed";
        public override BlockState[] PossibleStates { get; }
        public Cyan_bedBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(874, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(875, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(876, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(877, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(878, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(879, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(880, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(881, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(882, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(883, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(884, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(885, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

                new BlockState(886, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "head"},
 }),

                new BlockState(887, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "true"},

            {"part", "foot"},
 }),

                new BlockState(888, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "head"},
 }),

                new BlockState(889, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"occupied", "false"},

            {"part", "foot"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Cyan_bedItem() };

        }
    }
}
