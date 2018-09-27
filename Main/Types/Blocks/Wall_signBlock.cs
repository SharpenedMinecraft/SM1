
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Wall_signBlock : Block
    {
        public override string BlockId => "minecraft:wall_sign";
        public override BlockState[] PossibleStates { get; }
        public Wall_signBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3251, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"waterlogged", "true"},
 }),

                new BlockState(3252, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"waterlogged", "false"},
 }),

                new BlockState(3253, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"waterlogged", "true"},
 }),

                new BlockState(3254, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"waterlogged", "false"},
 }),

                new BlockState(3255, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"waterlogged", "true"},
 }),

                new BlockState(3256, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"waterlogged", "false"},
 }),

                new BlockState(3257, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"waterlogged", "true"},
 }),

                new BlockState(3258, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] {  };

        }
    }
}
