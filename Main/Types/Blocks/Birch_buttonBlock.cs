
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_buttonBlock : Block
    {
        public override string BlockId => "minecraft:birch_button";
        public override BlockState[] PossibleStates { get; }
        public Birch_buttonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5333, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5334, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5335, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5336, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5337, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5338, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5339, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5340, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5341, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5342, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5343, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5344, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5345, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5346, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5347, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5348, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5349, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5350, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5351, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5352, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5353, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5354, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5355, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5356, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[9];

            Drops = new ItemStack[] { new Birch_buttonItem() };

        }
    }
}
