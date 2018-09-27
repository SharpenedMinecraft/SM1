
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_fence_gateBlock : Block
    {
        public override string BlockId => "minecraft:acacia_fence_gate";
        public override BlockState[] PossibleStates { get; }
        public Acacia_fence_gateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7435, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7436, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7437, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7438, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7439, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7440, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7441, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7442, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7443, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7444, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7445, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7446, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7447, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7448, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7449, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7450, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7451, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7452, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7453, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7454, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7455, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7456, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7457, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7458, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7459, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7460, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7461, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7462, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7463, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7464, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7465, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7466, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[7];

            Drops = new ItemStack[] { new Acacia_fence_gateItem() };

        }
    }
}
