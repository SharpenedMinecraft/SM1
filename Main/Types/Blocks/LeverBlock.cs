
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class LeverBlock : Block
    {
        public override string BlockId => "minecraft:lever";
        public override BlockState[] PossibleStates { get; }
        public LeverBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3259, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(3260, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(3261, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(3262, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(3263, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(3264, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(3265, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(3266, new Dictionary<string, string>
                { 
            {"face", "floor"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(3267, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(3268, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(3269, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(3270, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(3271, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(3272, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(3273, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(3274, new Dictionary<string, string>
                { 
            {"face", "wall"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(3275, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(3276, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(3277, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(3278, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(3279, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(3280, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(3281, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(3282, new Dictionary<string, string>
                { 
            {"face", "ceiling"},

            {"facing", "west"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[9];

            Drops = new ItemStack[] { new LeverItem() };

        }
    }
}
