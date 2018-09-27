
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_doorBlock : Block
    {
        public override string BlockId => "minecraft:spruce_door";
        public override BlockState[] PossibleStates { get; }
        public Spruce_doorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7659, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7660, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7661, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7662, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7663, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7664, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7665, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7666, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7667, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7668, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7669, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7670, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7671, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7672, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7673, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7674, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7675, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7676, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7677, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7678, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7679, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7680, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7681, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7682, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7683, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7684, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7685, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7686, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7687, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7688, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7689, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7690, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7691, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7692, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7693, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7694, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7695, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7696, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7697, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7698, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7699, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7700, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7701, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7702, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7703, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7704, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7705, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7706, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7707, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7708, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7709, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7710, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7711, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7712, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7713, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7714, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7715, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7716, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7717, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7718, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7719, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7720, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7721, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7722, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Spruce_doorItem() };

        }
    }
}
