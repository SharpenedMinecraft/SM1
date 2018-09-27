
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class LadderBlock : Block
    {
        public override string BlockId => "minecraft:ladder";
        public override BlockState[] PossibleStates { get; }
        public LadderBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3153, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"waterlogged", "true"},
 }),

                new BlockState(3154, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"waterlogged", "false"},
 }),

                new BlockState(3155, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"waterlogged", "true"},
 }),

                new BlockState(3156, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"waterlogged", "false"},
 }),

                new BlockState(3157, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"waterlogged", "true"},
 }),

                new BlockState(3158, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"waterlogged", "false"},
 }),

                new BlockState(3159, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"waterlogged", "true"},
 }),

                new BlockState(3160, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new LadderItem() };

        }
    }
}
