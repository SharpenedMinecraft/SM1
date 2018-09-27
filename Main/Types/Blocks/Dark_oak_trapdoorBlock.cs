
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_trapdoorBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_trapdoor";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_trapdoorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3895, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3896, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3897, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3898, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3899, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3900, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3901, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3902, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3903, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3904, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3905, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3906, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3907, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3908, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3909, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3910, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3911, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3912, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3913, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3914, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3915, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3916, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3917, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3918, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3919, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3920, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3921, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3922, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3923, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3924, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3925, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3926, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3927, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3928, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3929, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3930, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3931, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3932, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3933, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3934, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3935, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3936, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3937, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3938, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3939, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3940, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3941, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3942, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3943, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3944, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3945, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3946, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3947, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3948, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3949, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3950, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3951, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3952, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3953, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3954, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3955, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3956, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3957, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3958, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[15];

            Drops = new ItemStack[] { new Dark_oak_trapdoorItem() };

        }
    }
}
