
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Trapped_chestBlock : Block
    {
        public override string BlockId => "minecraft:trapped_chest";
        public override BlockState[] PossibleStates { get; }
        public Trapped_chestBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5561, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(5562, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(5563, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5564, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5565, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5566, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5567, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(5568, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(5569, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5570, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5571, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5572, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5573, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(5574, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(5575, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5576, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5577, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5578, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

                new BlockState(5579, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(5580, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(5581, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(5582, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(5583, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(5584, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Trapped_chestItem() };

        }
    }
}
