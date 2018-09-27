
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Iron_doorBlock : Block
    {
        public override string BlockId => "minecraft:iron_door";
        public override BlockState[] PossibleStates { get; }
        public Iron_doorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3285, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3286, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3287, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3288, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3289, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3290, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3291, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3292, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3293, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3294, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3295, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3296, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3297, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3298, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3299, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3300, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3301, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3302, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3303, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3304, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3305, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3306, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3307, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3308, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3309, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3310, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3311, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3312, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3313, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3314, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3315, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3316, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3317, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3318, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3319, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3320, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3321, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3322, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3323, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3324, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3325, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3326, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3327, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3328, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3329, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3330, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3331, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3332, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3333, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3334, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3335, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3336, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3337, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3338, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3339, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3340, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3341, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3342, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3343, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3344, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3345, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3346, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3347, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3348, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Iron_doorItem() };

        }
    }
}
