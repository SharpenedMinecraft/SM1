
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class RepeaterBlock : Block
    {
        public override string BlockId => "minecraft:repeater";
        public override BlockState[] PossibleStates { get; }
        public RepeaterBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3495, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3496, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3497, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3498, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3499, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3500, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3501, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3502, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3503, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3504, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3505, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3506, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3507, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3508, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3509, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3510, new Dictionary<string, string>
                { 
            {"delay", "1"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3511, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3512, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3513, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3514, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3515, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3516, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3517, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3518, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3519, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3520, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3521, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3522, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3523, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3524, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3525, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3526, new Dictionary<string, string>
                { 
            {"delay", "2"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3527, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3528, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3529, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3530, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3531, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3532, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3533, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3534, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3535, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3536, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3537, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3538, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3539, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3540, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3541, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3542, new Dictionary<string, string>
                { 
            {"delay", "3"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3543, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3544, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "north"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3545, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3546, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "north"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3547, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3548, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "east"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3549, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3550, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "east"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3551, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3552, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "south"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3553, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3554, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "south"},

            {"locked", "false"},

            {"powered", "false"},
 }),

                new BlockState(3555, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "true"},
 }),

                new BlockState(3556, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "west"},

            {"locked", "true"},

            {"powered", "false"},
 }),

                new BlockState(3557, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "true"},
 }),

                new BlockState(3558, new Dictionary<string, string>
                { 
            {"delay", "4"},

            {"facing", "west"},

            {"locked", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new RepeaterItem() };

        }
    }
}
