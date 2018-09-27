
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Command_blockBlock : Block
    {
        public override string BlockId => "minecraft:command_block";
        public override BlockState[] PossibleStates { get; }
        public Command_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5106, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "north"},
 }),

                new BlockState(5107, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "east"},
 }),

                new BlockState(5108, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "south"},
 }),

                new BlockState(5109, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "west"},
 }),

                new BlockState(5110, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "up"},
 }),

                new BlockState(5111, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "down"},
 }),

                new BlockState(5112, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "north"},
 }),

                new BlockState(5113, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "east"},
 }),

                new BlockState(5114, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "south"},
 }),

                new BlockState(5115, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "west"},
 }),

                new BlockState(5116, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "up"},
 }),

                new BlockState(5117, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "down"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Command_blockItem() };

        }
    }
}
