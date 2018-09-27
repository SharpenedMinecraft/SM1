
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class FurnaceBlock : Block
    {
        public override string BlockId => "minecraft:furnace";
        public override BlockState[] PossibleStates { get; }
        public FurnaceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3049, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"lit", "true"},
 }),

                new BlockState(3050, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"lit", "false"},
 }),

                new BlockState(3051, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"lit", "true"},
 }),

                new BlockState(3052, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"lit", "false"},
 }),

                new BlockState(3053, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"lit", "true"},
 }),

                new BlockState(3054, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"lit", "false"},
 }),

                new BlockState(3055, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"lit", "true"},
 }),

                new BlockState(3056, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"lit", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new FurnaceItem() };

        }
    }
}
