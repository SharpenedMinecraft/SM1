
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_fence_gateBlock : Block
    {
        public override string BlockId => "minecraft:spruce_fence_gate";
        public override BlockState[] PossibleStates { get; }
        public Spruce_fence_gateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7339, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7340, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7341, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7342, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7343, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7344, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7345, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7346, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7347, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7348, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7349, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7350, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7351, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7352, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7353, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7354, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7355, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7356, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7357, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7358, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7359, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7360, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7361, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7362, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7363, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7364, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7365, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7366, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7367, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7368, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7369, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7370, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[7];

            Drops = new ItemStack[] { new Spruce_fence_gateItem() };

        }
    }
}
