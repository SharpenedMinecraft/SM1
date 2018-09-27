
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Tripwire_hookBlock : Block
    {
        public override string BlockId => "minecraft:tripwire_hook";
        public override BlockState[] PossibleStates { get; }
        public Tripwire_hookBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4721, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(4722, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(4723, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(4724, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(4725, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(4726, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(4727, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(4728, new Dictionary<string, string>
                { 
            {"attached", "true"},

            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(4729, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(4730, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(4731, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(4732, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(4733, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(4734, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(4735, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(4736, new Dictionary<string, string>
                { 
            {"attached", "false"},

            {"facing", "west"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[9];

            Drops = new ItemStack[] { new Tripwire_hookItem() };

        }
    }
}
