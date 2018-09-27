
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Ender_chestBlock : Block
    {
        public override string BlockId => "minecraft:ender_chest";
        public override BlockState[] PossibleStates { get; }
        public Ender_chestBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4713, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"waterlogged", "true"},
 }),

                new BlockState(4714, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"waterlogged", "false"},
 }),

                new BlockState(4715, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"waterlogged", "true"},
 }),

                new BlockState(4716, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"waterlogged", "false"},
 }),

                new BlockState(4717, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"waterlogged", "true"},
 }),

                new BlockState(4718, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"waterlogged", "false"},
 }),

                new BlockState(4719, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"waterlogged", "true"},
 }),

                new BlockState(4720, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Ender_chestItem() };

        }
    }
}
