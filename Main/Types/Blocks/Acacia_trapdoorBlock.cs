
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_trapdoorBlock : Block
    {
        public override string BlockId => "minecraft:acacia_trapdoor";
        public override BlockState[] PossibleStates { get; }
        public Acacia_trapdoorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3831, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3832, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3833, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3834, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3835, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3836, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3837, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3838, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3839, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3840, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3841, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3842, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3843, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3844, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3845, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3846, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3847, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3848, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3849, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3850, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3851, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3852, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3853, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3854, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3855, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3856, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3857, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3858, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3859, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3860, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3861, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3862, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3863, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3864, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3865, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3866, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3867, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3868, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3869, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3870, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3871, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3872, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3873, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3874, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3875, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3876, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3877, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3878, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3879, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3880, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3881, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3882, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3883, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3884, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3885, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3886, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3887, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3888, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3889, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3890, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "true"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

                new BlockState(3891, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "true"},
 }),

                new BlockState(3892, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "true"},

            {"waterlogged", "false"},
 }),

                new BlockState(3893, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "true"},
 }),

                new BlockState(3894, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"open", "false"},

            {"powered", "false"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[15];

            Drops = new ItemStack[] { new Acacia_trapdoorItem() };

        }
    }
}
