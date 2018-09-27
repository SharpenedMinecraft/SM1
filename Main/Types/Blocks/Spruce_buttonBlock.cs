
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_buttonBlock : Block
    {
        public override string BlockId => "minecraft:spruce_button";
        public override BlockState[] PossibleStates { get; }
        public Spruce_buttonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5309, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5310, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5311, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5312, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5313, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5314, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5315, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5316, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5317, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5318, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5319, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5320, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5321, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5322, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5323, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5324, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5325, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5326, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5327, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5328, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5329, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5330, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5331, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5332, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[9];

            Drops = new ItemStack[] { new Spruce_buttonItem() };

        }
    }
}
