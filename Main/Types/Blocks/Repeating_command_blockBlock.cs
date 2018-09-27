
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Repeating_command_blockBlock : Block
    {
        public override string BlockId => "minecraft:repeating_command_block";
        public override BlockState[] PossibleStates { get; }
        public Repeating_command_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8146, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "north"},
 }),

                new BlockState(8147, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "east"},
 }),

                new BlockState(8148, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "south"},
 }),

                new BlockState(8149, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "west"},
 }),

                new BlockState(8150, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "up"},
 }),

                new BlockState(8151, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "down"},
 }),

                new BlockState(8152, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "north"},
 }),

                new BlockState(8153, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "east"},
 }),

                new BlockState(8154, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "south"},
 }),

                new BlockState(8155, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "west"},
 }),

                new BlockState(8156, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "up"},
 }),

                new BlockState(8157, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "down"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Repeating_command_blockItem() };

        }
    }
}
