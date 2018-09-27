
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class DispenserBlock : Block
    {
        public override string BlockId => "minecraft:dispenser";
        public override BlockState[] PossibleStates { get; }
        public DispenserBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(215, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"triggered", "true"},
 }),

                new BlockState(216, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"triggered", "false"},
 }),

                new BlockState(217, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"triggered", "true"},
 }),

                new BlockState(218, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"triggered", "false"},
 }),

                new BlockState(219, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"triggered", "true"},
 }),

                new BlockState(220, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"triggered", "false"},
 }),

                new BlockState(221, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"triggered", "true"},
 }),

                new BlockState(222, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"triggered", "false"},
 }),

                new BlockState(223, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"triggered", "true"},
 }),

                new BlockState(224, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"triggered", "false"},
 }),

                new BlockState(225, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"triggered", "true"},
 }),

                new BlockState(226, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"triggered", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new DispenserItem() };

        }
    }
}
