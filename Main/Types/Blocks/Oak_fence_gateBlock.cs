
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_fence_gateBlock : Block
    {
        public override string BlockId => "minecraft:oak_fence_gate";
        public override BlockState[] PossibleStates { get; }
        public Oak_fence_gateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4282, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4283, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4284, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4285, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4286, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4287, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4288, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4289, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4290, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4291, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4292, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4293, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4294, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4295, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4296, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4297, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4298, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4299, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4300, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4301, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4302, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4303, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4304, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4305, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4306, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4307, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4308, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4309, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "true"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(4310, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(4311, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(4312, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(4313, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"in_wall", "false"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[7];

            Drops = new ItemStack[] { new Oak_fence_gateItem() };

        }
    }
}
