
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_trapdoorBlock : Block
    {
        public override string BlockId => "minecraft:spruce_trapdoor";
        public override BlockState[] PossibleStates { get; }
        public Spruce_trapdoorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3639, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3640, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3641, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3642, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3643, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3644, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3645, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3646, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3647, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3648, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3649, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3650, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3651, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3652, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3653, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3654, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3655, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3656, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3657, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3658, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3659, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3660, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3661, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3662, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3663, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3664, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3665, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3666, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3667, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3668, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3669, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3670, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3671, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3672, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3673, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3674, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3675, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3676, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3677, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3678, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3679, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3680, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3681, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3682, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3683, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3684, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3685, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3686, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3687, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3688, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3689, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3690, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3691, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3692, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3693, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3694, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3695, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3696, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3697, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3698, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3699, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3700, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3701, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3702, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[15];

            Drops = new ItemStack[] { new Spruce_trapdoorItem() };

        }
    }
}
