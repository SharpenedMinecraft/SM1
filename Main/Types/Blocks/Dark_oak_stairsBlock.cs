
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_stairsBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_stairs";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_stairsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6394, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6395, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6396, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6397, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6398, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6399, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6400, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6401, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6402, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6403, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6404, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6405, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6406, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6407, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6408, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6409, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6410, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6411, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6412, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6413, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6414, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6415, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6416, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6417, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6418, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6419, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6420, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6421, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6422, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6423, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6424, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6425, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6426, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6427, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6428, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6429, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6430, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6431, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6432, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6433, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6434, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6435, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6436, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6437, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6438, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6439, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6440, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6441, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6442, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6443, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6444, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6445, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6446, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6447, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6448, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6449, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6450, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6451, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6452, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6453, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6454, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6455, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6456, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6457, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6458, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6459, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6460, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6461, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6462, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6463, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6464, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6465, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6466, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6467, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6468, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6469, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6470, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6471, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6472, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6473, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Dark_oak_stairsItem() };

        }
    }
}
