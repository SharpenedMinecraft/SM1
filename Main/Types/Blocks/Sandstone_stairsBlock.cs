
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Sandstone_stairsBlock : Block
    {
        public override string BlockId => "minecraft:sandstone_stairs";
        public override BlockState[] PossibleStates { get; }
        public Sandstone_stairsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4632, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4633, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4634, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4635, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4636, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4637, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4638, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4639, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4640, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4641, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4642, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4643, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4644, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4645, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4646, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4647, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4648, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4649, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4650, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4651, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4652, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4653, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4654, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4655, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4656, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4657, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4658, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4659, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4660, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4661, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4662, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4663, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4664, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4665, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4666, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4667, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4668, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4669, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4670, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4671, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4672, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4673, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4674, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4675, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4676, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4677, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4678, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4679, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4680, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4681, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4682, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4683, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4684, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4685, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4686, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4687, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4688, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4689, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4690, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4691, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4692, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4693, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4694, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4695, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4696, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4697, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4698, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4699, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4700, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4701, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4702, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(4703, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(4704, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4705, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4706, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4707, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(4708, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(4709, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(4710, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(4711, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Sandstone_stairsItem() };

        }
    }
}
