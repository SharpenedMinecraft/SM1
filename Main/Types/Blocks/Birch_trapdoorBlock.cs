
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_trapdoorBlock : Block
    {
        public override string BlockId => "minecraft:birch_trapdoor";
        public override BlockState[] PossibleStates { get; }
        public Birch_trapdoorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3703, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3704, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3705, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3706, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3707, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3708, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3709, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3710, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3711, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3712, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3713, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3714, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3715, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3716, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3717, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3718, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3719, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3720, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3721, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3722, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3723, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3724, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3725, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3726, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3727, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3728, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3729, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3730, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3731, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3732, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3733, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3734, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3735, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3736, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3737, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3738, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3739, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3740, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3741, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3742, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3743, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3744, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3745, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3746, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3747, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3748, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3749, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3750, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3751, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3752, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3753, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3754, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3755, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3756, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3757, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3758, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3759, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3760, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3761, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3762, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3763, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3764, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3765, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3766, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[15];

            Drops = new ItemStack[] { new Birch_trapdoorItem() };

        }
    }
}
