
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class ChestBlock : Block
    {
        public override string BlockId => "minecraft:chest";
        public override BlockState[] PossibleStates { get; }
        public ChestBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1710, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(1711, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(1712, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(1713, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(1714, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(1715, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

                new BlockState(1716, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(1717, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(1718, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(1719, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(1720, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(1721, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

                new BlockState(1722, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(1723, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(1724, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(1725, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(1726, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(1727, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

                new BlockState(1728, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "single"},

            {"waterlogged", "true"},
 }),

                new BlockState(1729, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "single"},

            {"waterlogged", "false"},
 }),

                new BlockState(1730, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "left"},

            {"waterlogged", "true"},
 }),

                new BlockState(1731, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "left"},

            {"waterlogged", "false"},
 }),

                new BlockState(1732, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "right"},

            {"waterlogged", "true"},
 }),

                new BlockState(1733, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"type", "right"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new ChestItem() };

        }
    }
}
