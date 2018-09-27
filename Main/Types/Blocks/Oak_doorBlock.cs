
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_doorBlock : Block
    {
        public override string BlockId => "minecraft:oak_door";
        public override BlockState[] PossibleStates { get; }
        public Oak_doorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3089, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3090, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3091, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3092, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3093, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3094, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3095, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3096, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3097, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3098, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3099, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3100, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3101, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3102, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3103, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3104, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3105, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3106, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3107, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3108, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3109, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3110, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3111, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3112, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3113, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3114, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3115, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3116, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3117, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3118, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3119, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3120, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3121, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3122, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3123, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3124, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3125, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3126, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3127, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3128, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3129, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3130, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3131, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3132, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3133, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3134, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3135, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3136, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3137, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3138, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3139, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3140, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3141, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3142, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3143, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3144, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3145, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3146, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3147, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3148, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(3149, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(3150, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(3151, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(3152, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Oak_doorItem() };

        }
    }
}
