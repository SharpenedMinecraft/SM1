
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_bannerBlock : Block
    {
        public override string BlockId => "minecraft:lime_banner";
        public override BlockState[] PossibleStates { get; }
        public Lime_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6916, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6917, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6918, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6919, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6920, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6921, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6922, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6923, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6924, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6925, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6926, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6927, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6928, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6929, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6930, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6931, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_bannerItem() };

        }
    }
}
