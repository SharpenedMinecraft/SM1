
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_prismarine_stairsBlock : Block
    {
        public override string BlockId => "minecraft:dark_prismarine_stairs";
        public override BlockState[] PossibleStates { get; }
        public Dark_prismarine_stairsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6703, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6704, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6705, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6706, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6707, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6708, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6709, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6710, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6711, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6712, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6713, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6714, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6715, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6716, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6717, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6718, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6719, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6720, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6721, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6722, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6723, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6724, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6725, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6726, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6727, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6728, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6729, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6730, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6731, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6732, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6733, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6734, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6735, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6736, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6737, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6738, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6739, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6740, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6741, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6742, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6743, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6744, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6745, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6746, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6747, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6748, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6749, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6750, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6751, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6752, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6753, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6754, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6755, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6756, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6757, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6758, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6759, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6760, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6761, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6762, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6763, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6764, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6765, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6766, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6767, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6768, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6769, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6770, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6771, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6772, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6773, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(6774, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(6775, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6776, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6777, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6778, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(6779, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(6780, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(6781, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(6782, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Dark_prismarine_stairsItem() };

        }
    }
}
