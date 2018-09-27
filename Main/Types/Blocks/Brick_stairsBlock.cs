
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brick_stairsBlock : Block
    {
        public override string BlockId => "minecraft:brick_stairs";
        public override BlockState[] PossibleStates { get; }
        public Brick_stairsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4314, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4315, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4316, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4317, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4318, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4319, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4320, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4321, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4322, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4323, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4324, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4325, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4326, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4327, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4328, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4329, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4330, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4331, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4332, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4333, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4334, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4335, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4336, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4337, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4338, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4339, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4340, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4341, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4342, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4343, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4344, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4345, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4346, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4347, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4348, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4349, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4350, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4351, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4352, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4353, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4354, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4355, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4356, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4357, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4358, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4359, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4360, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4361, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4362, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4363, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4364, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4365, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4366, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4367, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4368, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4369, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4370, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4371, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4372, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4373, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4374, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4375, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4376, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4377, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4378, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4379, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4380, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4381, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4382, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4383, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4384, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4385, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4386, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4387, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4388, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4389, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4390, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4391, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4392, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4393, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Brick_stairsItem() };

        }
    }
}
