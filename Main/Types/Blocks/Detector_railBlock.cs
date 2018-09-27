
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Detector_railBlock : Block
    {
        public override string BlockId => "minecraft:detector_rail";
        public override BlockState[] PossibleStates { get; }
        public Detector_railBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(998, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "north_south"},
 }),

                new BlockState(999, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "east_west"},
 }),

                new BlockState(1000, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_east"},
 }),

                new BlockState(1001, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_west"},
 }),

                new BlockState(1002, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_north"},
 }),

                new BlockState(1003, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_south"},
 }),

                new BlockState(1004, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "north_south"},
 }),

                new BlockState(1005, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "east_west"},
 }),

                new BlockState(1006, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_east"},
 }),

                new BlockState(1007, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_west"},
 }),

                new BlockState(1008, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_north"},
 }),

                new BlockState(1009, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_south"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Detector_railItem() };

        }
    }
}
