
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_trapdoorBlock : Block
    {
        public override string BlockId => "minecraft:jungle_trapdoor";
        public override BlockState[] PossibleStates { get; }
        public Jungle_trapdoorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3767, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3768, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3769, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3770, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3771, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3772, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3773, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3774, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3775, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3776, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3777, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3778, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3779, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3780, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3781, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3782, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3783, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3784, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3785, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3786, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3787, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3788, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3789, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3790, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3791, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3792, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3793, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3794, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3795, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3796, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3797, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3798, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3799, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3800, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3801, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3802, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3803, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3804, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3805, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3806, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3807, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3808, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3809, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3810, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3811, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3812, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3813, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3814, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3815, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3816, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3817, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3818, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3819, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3820, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3821, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3822, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3823, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3824, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3825, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3826, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3827, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3828, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3829, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3830, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[15];

            Drops = new ItemStack[] { new Jungle_trapdoorItem() };

        }
    }
}
