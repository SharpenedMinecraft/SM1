
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_buttonBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_button";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_buttonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5405, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5406, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5407, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5408, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5409, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5410, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5411, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5412, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5413, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5414, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5415, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5416, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5417, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5418, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5419, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5420, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5421, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5422, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5423, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5424, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5425, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5426, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5427, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5428, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[9];

            Drops = new ItemStack[] { new Dark_oak_buttonItem() };

        }
    }
}
