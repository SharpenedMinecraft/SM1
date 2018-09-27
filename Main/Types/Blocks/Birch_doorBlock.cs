
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_doorBlock : Block
    {
        public override string BlockId => "minecraft:birch_door";
        public override BlockState[] PossibleStates { get; }
        public Birch_doorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7723, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7724, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7725, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7726, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7727, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7728, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7729, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7730, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7731, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7732, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7733, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7734, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7735, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7736, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7737, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7738, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7739, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7740, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7741, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7742, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7743, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7744, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7745, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7746, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7747, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7748, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7749, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7750, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7751, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7752, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7753, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7754, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7755, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7756, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7757, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7758, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7759, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7760, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7761, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7762, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7763, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7764, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7765, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7766, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7767, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7768, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7769, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7770, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7771, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7772, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7773, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7774, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7775, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7776, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7777, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7778, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7779, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7780, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7781, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7782, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7783, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7784, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7785, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7786, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Birch_doorItem() };

        }
    }
}
