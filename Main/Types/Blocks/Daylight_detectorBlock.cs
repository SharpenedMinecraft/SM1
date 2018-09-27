
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Daylight_detectorBlock : Block
    {
        public override string BlockId => "minecraft:daylight_detector";
        public override BlockState[] PossibleStates { get; }
        public Daylight_detectorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5633, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "0"},
 }),

                new BlockState(5634, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "1"},
 }),

                new BlockState(5635, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "2"},
 }),

                new BlockState(5636, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "3"},
 }),

                new BlockState(5637, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "4"},
 }),

                new BlockState(5638, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "5"},
 }),

                new BlockState(5639, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "6"},
 }),

                new BlockState(5640, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "7"},
 }),

                new BlockState(5641, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "8"},
 }),

                new BlockState(5642, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "9"},
 }),

                new BlockState(5643, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "10"},
 }),

                new BlockState(5644, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "11"},
 }),

                new BlockState(5645, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "12"},
 }),

                new BlockState(5646, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "13"},
 }),

                new BlockState(5647, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "14"},
 }),

                new BlockState(5648, new Dictionary<string, string>
                { 
            {"inverted", "true"},

            {"power", "15"},
 }),

                new BlockState(5649, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "0"},
 }),

                new BlockState(5650, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "1"},
 }),

                new BlockState(5651, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "2"},
 }),

                new BlockState(5652, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "3"},
 }),

                new BlockState(5653, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "4"},
 }),

                new BlockState(5654, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "5"},
 }),

                new BlockState(5655, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "6"},
 }),

                new BlockState(5656, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "7"},
 }),

                new BlockState(5657, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "8"},
 }),

                new BlockState(5658, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "9"},
 }),

                new BlockState(5659, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "10"},
 }),

                new BlockState(5660, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "11"},
 }),

                new BlockState(5661, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "12"},
 }),

                new BlockState(5662, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "13"},
 }),

                new BlockState(5663, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "14"},
 }),

                new BlockState(5664, new Dictionary<string, string>
                { 
            {"inverted", "false"},

            {"power", "15"},
 }),

            };
            State = PossibleStates[16];

            Drops = new ItemStack[] { new Daylight_detectorItem() };

        }
    }
}
