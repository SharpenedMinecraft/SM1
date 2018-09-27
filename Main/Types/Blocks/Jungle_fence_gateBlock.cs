
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_fence_gateBlock : Block
    {
        public override string BlockId => "minecraft:jungle_fence_gate";
        public override BlockState[] PossibleStates { get; }
        public Jungle_fence_gateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7403, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7404, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7405, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7406, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7407, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7408, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7409, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7410, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7411, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7412, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7413, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7414, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7415, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7416, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7417, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7418, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7419, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7420, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7421, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7422, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7423, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7424, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7425, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7426, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7427, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7428, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7429, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7430, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7431, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7432, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7433, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7434, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[7];

            Drops = new ItemStack[] { new Jungle_fence_gateItem() };

        }
    }
}
