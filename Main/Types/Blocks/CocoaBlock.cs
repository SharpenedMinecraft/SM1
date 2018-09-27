
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CocoaBlock : Block
    {
        public override string BlockId => "minecraft:cocoa";
        public override BlockState[] PossibleStates { get; }
        public CocoaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4620, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"facing", "north"},
 }),

                new BlockState(4621, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"facing", "east"},
 }),

                new BlockState(4622, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"facing", "south"},
 }),

                new BlockState(4623, new Dictionary<string, string>
                { 
            {"age", "0"},

            {"facing", "west"},
 }),

                new BlockState(4624, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"facing", "north"},
 }),

                new BlockState(4625, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"facing", "east"},
 }),

                new BlockState(4626, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"facing", "south"},
 }),

                new BlockState(4627, new Dictionary<string, string>
                { 
            {"age", "1"},

            {"facing", "west"},
 }),

                new BlockState(4628, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"facing", "north"},
 }),

                new BlockState(4629, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"facing", "east"},
 }),

                new BlockState(4630, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"facing", "south"},
 }),

                new BlockState(4631, new Dictionary<string, string>
                { 
            {"age", "2"},

            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
