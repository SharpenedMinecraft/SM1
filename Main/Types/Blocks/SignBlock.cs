
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SignBlock : Block
    {
        public override string BlockId => "minecraft:sign";
        public override BlockState[] PossibleStates { get; }
        public SignBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3057, new Dictionary<string, string>
                { 
            {"rotation", "0"},

            {"waterlogged", "true"},
 }),

                new BlockState(3058, new Dictionary<string, string>
                { 
            {"rotation", "0"},

            {"waterlogged", "false"},
 }),

                new BlockState(3059, new Dictionary<string, string>
                { 
            {"rotation", "1"},

            {"waterlogged", "true"},
 }),

                new BlockState(3060, new Dictionary<string, string>
                { 
            {"rotation", "1"},

            {"waterlogged", "false"},
 }),

                new BlockState(3061, new Dictionary<string, string>
                { 
            {"rotation", "2"},

            {"waterlogged", "true"},
 }),

                new BlockState(3062, new Dictionary<string, string>
                { 
            {"rotation", "2"},

            {"waterlogged", "false"},
 }),

                new BlockState(3063, new Dictionary<string, string>
                { 
            {"rotation", "3"},

            {"waterlogged", "true"},
 }),

                new BlockState(3064, new Dictionary<string, string>
                { 
            {"rotation", "3"},

            {"waterlogged", "false"},
 }),

                new BlockState(3065, new Dictionary<string, string>
                { 
            {"rotation", "4"},

            {"waterlogged", "true"},
 }),

                new BlockState(3066, new Dictionary<string, string>
                { 
            {"rotation", "4"},

            {"waterlogged", "false"},
 }),

                new BlockState(3067, new Dictionary<string, string>
                { 
            {"rotation", "5"},

            {"waterlogged", "true"},
 }),

                new BlockState(3068, new Dictionary<string, string>
                { 
            {"rotation", "5"},

            {"waterlogged", "false"},
 }),

                new BlockState(3069, new Dictionary<string, string>
                { 
            {"rotation", "6"},

            {"waterlogged", "true"},
 }),

                new BlockState(3070, new Dictionary<string, string>
                { 
            {"rotation", "6"},

            {"waterlogged", "false"},
 }),

                new BlockState(3071, new Dictionary<string, string>
                { 
            {"rotation", "7"},

            {"waterlogged", "true"},
 }),

                new BlockState(3072, new Dictionary<string, string>
                { 
            {"rotation", "7"},

            {"waterlogged", "false"},
 }),

                new BlockState(3073, new Dictionary<string, string>
                { 
            {"rotation", "8"},

            {"waterlogged", "true"},
 }),

                new BlockState(3074, new Dictionary<string, string>
                { 
            {"rotation", "8"},

            {"waterlogged", "false"},
 }),

                new BlockState(3075, new Dictionary<string, string>
                { 
            {"rotation", "9"},

            {"waterlogged", "true"},
 }),

                new BlockState(3076, new Dictionary<string, string>
                { 
            {"rotation", "9"},

            {"waterlogged", "false"},
 }),

                new BlockState(3077, new Dictionary<string, string>
                { 
            {"rotation", "10"},

            {"waterlogged", "true"},
 }),

                new BlockState(3078, new Dictionary<string, string>
                { 
            {"rotation", "10"},

            {"waterlogged", "false"},
 }),

                new BlockState(3079, new Dictionary<string, string>
                { 
            {"rotation", "11"},

            {"waterlogged", "true"},
 }),

                new BlockState(3080, new Dictionary<string, string>
                { 
            {"rotation", "11"},

            {"waterlogged", "false"},
 }),

                new BlockState(3081, new Dictionary<string, string>
                { 
            {"rotation", "12"},

            {"waterlogged", "true"},
 }),

                new BlockState(3082, new Dictionary<string, string>
                { 
            {"rotation", "12"},

            {"waterlogged", "false"},
 }),

                new BlockState(3083, new Dictionary<string, string>
                { 
            {"rotation", "13"},

            {"waterlogged", "true"},
 }),

                new BlockState(3084, new Dictionary<string, string>
                { 
            {"rotation", "13"},

            {"waterlogged", "false"},
 }),

                new BlockState(3085, new Dictionary<string, string>
                { 
            {"rotation", "14"},

            {"waterlogged", "true"},
 }),

                new BlockState(3086, new Dictionary<string, string>
                { 
            {"rotation", "14"},

            {"waterlogged", "false"},
 }),

                new BlockState(3087, new Dictionary<string, string>
                { 
            {"rotation", "15"},

            {"waterlogged", "true"},
 }),

                new BlockState(3088, new Dictionary<string, string>
                { 
            {"rotation", "15"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new SignItem() };

        }
    }
}
