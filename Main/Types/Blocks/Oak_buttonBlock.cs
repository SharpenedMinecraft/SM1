
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_buttonBlock : Block
    {
        public override string BlockId => "minecraft:oak_button";
        public override BlockState[] PossibleStates { get; }
        public Oak_buttonBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5285, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5286, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5287, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5288, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5289, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5290, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5291, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5292, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5293, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5294, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5295, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5296, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5297, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5298, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5299, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5300, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(5301, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(5302, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(5303, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(5304, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(5305, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(5306, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(5307, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(5308, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[9];

            Drops = new ItemStack[] { new Oak_buttonItem() };

        }
    }
}
