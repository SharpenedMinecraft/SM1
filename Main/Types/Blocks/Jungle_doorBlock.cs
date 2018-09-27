
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_doorBlock : Block
    {
        public override string BlockId => "minecraft:jungle_door";
        public override BlockState[] PossibleStates { get; }
        public Jungle_doorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7787, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7788, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7789, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7790, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7791, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7792, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7793, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7794, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7795, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7796, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7797, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7798, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7799, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7800, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7801, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7802, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7803, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7804, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7805, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7806, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7807, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7808, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7809, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7810, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7811, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7812, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7813, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7814, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7815, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7816, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7817, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7818, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7819, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7820, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7821, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7822, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7823, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7824, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7825, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7826, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7827, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7828, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7829, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7830, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7831, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7832, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7833, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7834, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7835, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7836, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7837, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7838, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7839, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7840, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7841, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7842, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "upper"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7843, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7844, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7845, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7846, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "left"},

            {"open", "false"},

            {"powered", "false"},
 }),

                new BlockState(7847, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "true"},
 }),

                new BlockState(7848, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "true"},

            {"powered", "false"},
 }),

                new BlockState(7849, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "true"},
 }),

                new BlockState(7850, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"half", "lower"},

            {"hinge", "right"},

            {"open", "false"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[11];

            Drops = new ItemStack[] { new Jungle_doorItem() };

        }
    }
}
