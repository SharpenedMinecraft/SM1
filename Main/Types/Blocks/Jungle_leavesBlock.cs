
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_leavesBlock : Block
    {
        public override string BlockId => "minecraft:jungle_leaves";
        public override BlockState[] PossibleStates { get; }
        public Jungle_leavesBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(168, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "true"},
 }),

                new BlockState(169, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "false"},
 }),

                new BlockState(170, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "true"},
 }),

                new BlockState(171, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "false"},
 }),

                new BlockState(172, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "true"},
 }),

                new BlockState(173, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "false"},
 }),

                new BlockState(174, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "true"},
 }),

                new BlockState(175, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "false"},
 }),

                new BlockState(176, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "true"},
 }),

                new BlockState(177, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "false"},
 }),

                new BlockState(178, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "true"},
 }),

                new BlockState(179, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "false"},
 }),

                new BlockState(180, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "true"},
 }),

                new BlockState(181, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "false"},
 }),

            };
            State = PossibleStates[13];

            Drops = new ItemStack[] { new Jungle_leavesItem() };

        }
    }
}
