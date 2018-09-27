
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_fence_gateBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_fence_gate";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_fence_gateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7467, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7468, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7469, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7470, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7471, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7472, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7473, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7474, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7475, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7476, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7477, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7478, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7479, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7480, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7481, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7482, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7483, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7484, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7485, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7486, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7487, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7488, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7489, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7490, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7491, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7492, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7493, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7494, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7495, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7496, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7497, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7498, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[7];

            Drops = new ItemStack[] { new Dark_oak_fence_gateItem() };

        }
    }
}
