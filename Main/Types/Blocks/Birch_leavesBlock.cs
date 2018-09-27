
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_leavesBlock : Block
    {
        public override string BlockId => "minecraft:birch_leaves";
        public override BlockState[] PossibleStates { get; }
        public Birch_leavesBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(154, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "true"},
 }),

                new BlockState(155, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "false"},
 }),

                new BlockState(156, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "true"},
 }),

                new BlockState(157, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "false"},
 }),

                new BlockState(158, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "true"},
 }),

                new BlockState(159, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "false"},
 }),

                new BlockState(160, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "true"},
 }),

                new BlockState(161, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "false"},
 }),

                new BlockState(162, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "true"},
 }),

                new BlockState(163, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "false"},
 }),

                new BlockState(164, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "true"},
 }),

                new BlockState(165, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "false"},
 }),

                new BlockState(166, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "true"},
 }),

                new BlockState(167, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "false"},
 }),

            };
            State = PossibleStates[13];

            Drops = new ItemStack[] { new Birch_leavesItem() };

        }
    }
}
