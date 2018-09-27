
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class HopperBlock : Block
    {
        public override string BlockId => "minecraft:hopper";
        public override BlockState[] PossibleStates { get; }
        public HopperBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5667, new Dictionary<string, string>
                { 
            {"enabled", "true"},

            {"facing", "down"},
 }),

                new BlockState(5668, new Dictionary<string, string>
                { 
            {"enabled", "true"},

            {"facing", "north"},
 }),

                new BlockState(5669, new Dictionary<string, string>
                { 
            {"enabled", "true"},

            {"facing", "south"},
 }),

                new BlockState(5670, new Dictionary<string, string>
                { 
            {"enabled", "true"},

            {"facing", "west"},
 }),

                new BlockState(5671, new Dictionary<string, string>
                { 
            {"enabled", "true"},

            {"facing", "east"},
 }),

                new BlockState(5672, new Dictionary<string, string>
                { 
            {"enabled", "false"},

            {"facing", "down"},
 }),

                new BlockState(5673, new Dictionary<string, string>
                { 
            {"enabled", "false"},

            {"facing", "north"},
 }),

                new BlockState(5674, new Dictionary<string, string>
                { 
            {"enabled", "false"},

            {"facing", "south"},
 }),

                new BlockState(5675, new Dictionary<string, string>
                { 
            {"enabled", "false"},

            {"facing", "west"},
 }),

                new BlockState(5676, new Dictionary<string, string>
                { 
            {"enabled", "false"},

            {"facing", "east"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new HopperItem() };

        }
    }
}
