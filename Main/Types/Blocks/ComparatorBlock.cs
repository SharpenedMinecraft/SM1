
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class ComparatorBlock : Block
    {
        public override string BlockId => "minecraft:comparator";
        public override BlockState[] PossibleStates { get; }
        public ComparatorBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5617, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"mode", "compare"},

            {"powered", "true"},
 }),

                new BlockState(5618, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"mode", "compare"},

            {"powered", "false"},
 }),

                new BlockState(5619, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"mode", "subtract"},

            {"powered", "true"},
 }),

                new BlockState(5620, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"mode", "subtract"},

            {"powered", "false"},
 }),

                new BlockState(5621, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"mode", "compare"},

            {"powered", "true"},
 }),

                new BlockState(5622, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"mode", "compare"},

            {"powered", "false"},
 }),

                new BlockState(5623, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"mode", "subtract"},

            {"powered", "true"},
 }),

                new BlockState(5624, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"mode", "subtract"},

            {"powered", "false"},
 }),

                new BlockState(5625, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"mode", "compare"},

            {"powered", "true"},
 }),

                new BlockState(5626, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"mode", "compare"},

            {"powered", "false"},
 }),

                new BlockState(5627, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"mode", "subtract"},

            {"powered", "true"},
 }),

                new BlockState(5628, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"mode", "subtract"},

            {"powered", "false"},
 }),

                new BlockState(5629, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"mode", "compare"},

            {"powered", "true"},
 }),

                new BlockState(5630, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"mode", "compare"},

            {"powered", "false"},
 }),

                new BlockState(5631, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"mode", "subtract"},

            {"powered", "true"},
 }),

                new BlockState(5632, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"mode", "subtract"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new ComparatorItem() };

        }
    }
}
