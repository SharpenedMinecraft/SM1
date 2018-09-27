
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Quartz_stairsBlock : Block
    {
        public override string BlockId => "minecraft:quartz_stairs";
        public override BlockState[] PossibleStates { get; }
        public Quartz_stairsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5682, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5683, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5684, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5685, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5686, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5687, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5688, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5689, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5690, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5691, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5692, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5693, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5694, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5695, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5696, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5697, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5698, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5699, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5700, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5701, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5702, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5703, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5704, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5705, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5706, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5707, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5708, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5709, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5710, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5711, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5712, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5713, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5714, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5715, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5716, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5717, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5718, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5719, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5720, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5721, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5722, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5723, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5724, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5725, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5726, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5727, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5728, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5729, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5730, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5731, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5732, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5733, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5734, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5735, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5736, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5737, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5738, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5739, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5740, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5741, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5742, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5743, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5744, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5745, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5746, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5747, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5748, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5749, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5750, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5751, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "top"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5752, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "true"},
 }),

                new BlockState(5753, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "straight"},

            {"waterlogged", "false"},
 }),

                new BlockState(5754, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5755, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5756, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5757, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "inner_right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5758, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5759, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5760, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5761, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "bottom"},

            {"shape", "outer_right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Quartz_stairsItem() };

        }
    }
}
