
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_leavesBlock : Block
    {
        public override string BlockId => "minecraft:spruce_leaves";
        public override BlockState[] PossibleStates { get; }
        public Spruce_leavesBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(140, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "true"},
 }),

                new BlockState(141, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "false"},
 }),

                new BlockState(142, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "true"},
 }),

                new BlockState(143, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "false"},
 }),

                new BlockState(144, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "true"},
 }),

                new BlockState(145, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "false"},
 }),

                new BlockState(146, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "true"},
 }),

                new BlockState(147, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "false"},
 }),

                new BlockState(148, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "true"},
 }),

                new BlockState(149, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "false"},
 }),

                new BlockState(150, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "true"},
 }),

                new BlockState(151, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "false"},
 }),

                new BlockState(152, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "true"},
 }),

                new BlockState(153, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "false"},
 }),

            };
            State = PossibleStates[13];

            Drops = new ItemStack[] { new Spruce_leavesItem() };

        }
    }
}
