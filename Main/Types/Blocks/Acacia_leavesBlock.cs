
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_leavesBlock : Block
    {
        public override string BlockId => "minecraft:acacia_leaves";
        public override BlockState[] PossibleStates { get; }
        public Acacia_leavesBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(182, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "true"},
 }),

                new BlockState(183, new Dictionary<string, string>
                { 
            {"distance", "1"},

            {"persistent", "false"},
 }),

                new BlockState(184, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "true"},
 }),

                new BlockState(185, new Dictionary<string, string>
                { 
            {"distance", "2"},

            {"persistent", "false"},
 }),

                new BlockState(186, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "true"},
 }),

                new BlockState(187, new Dictionary<string, string>
                { 
            {"distance", "3"},

            {"persistent", "false"},
 }),

                new BlockState(188, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "true"},
 }),

                new BlockState(189, new Dictionary<string, string>
                { 
            {"distance", "4"},

            {"persistent", "false"},
 }),

                new BlockState(190, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "true"},
 }),

                new BlockState(191, new Dictionary<string, string>
                { 
            {"distance", "5"},

            {"persistent", "false"},
 }),

                new BlockState(192, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "true"},
 }),

                new BlockState(193, new Dictionary<string, string>
                { 
            {"distance", "6"},

            {"persistent", "false"},
 }),

                new BlockState(194, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "true"},
 }),

                new BlockState(195, new Dictionary<string, string>
                { 
            {"distance", "7"},

            {"persistent", "false"},
 }),

            };
            State = PossibleStates[13];

            Drops = new ItemStack[] { new Acacia_leavesItem() };

        }
    }
}
