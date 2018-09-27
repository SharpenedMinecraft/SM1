
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chain_command_blockBlock : Block
    {
        public override string BlockId => "minecraft:chain_command_block";
        public override BlockState[] PossibleStates { get; }
        public Chain_command_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8158, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "north"},
 }),

                new BlockState(8159, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "east"},
 }),

                new BlockState(8160, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "south"},
 }),

                new BlockState(8161, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "west"},
 }),

                new BlockState(8162, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "up"},
 }),

                new BlockState(8163, new Dictionary<string, string>
                { 
            {"conditional", "true"},

            {"facing", "down"},
 }),

                new BlockState(8164, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "north"},
 }),

                new BlockState(8165, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "east"},
 }),

                new BlockState(8166, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "south"},
 }),

                new BlockState(8167, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "west"},
 }),

                new BlockState(8168, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "up"},
 }),

                new BlockState(8169, new Dictionary<string, string>
                { 
            {"conditional", "false"},

            {"facing", "down"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Chain_command_blockItem() };

        }
    }
}
