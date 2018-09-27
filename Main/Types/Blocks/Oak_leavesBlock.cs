
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_leavesBlock : Block
    {
        public override string BlockId => "minecraft:oak_leaves";
        public override BlockState[] PossibleStates { get; }
        public Oak_leavesBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(126, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "true"},
 }),

                new BlockState(127, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "false"},
 }),

                new BlockState(128, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "true"},
 }),

                new BlockState(129, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "false"},
 }),

                new BlockState(130, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "true"},
 }),

                new BlockState(131, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "false"},
 }),

                new BlockState(132, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "true"},
 }),

                new BlockState(133, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "false"},
 }),

                new BlockState(134, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "true"},
 }),

                new BlockState(135, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "false"},
 }),

                new BlockState(136, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "true"},
 }),

                new BlockState(137, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "false"},
 }),

                new BlockState(138, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "true"},
 }),

                new BlockState(139, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "false"},
 }),

            };
            State = PossibleStates[13];

            Drops = new ItemStack[] { new Oak_leavesItem() };

        }
    }
}
