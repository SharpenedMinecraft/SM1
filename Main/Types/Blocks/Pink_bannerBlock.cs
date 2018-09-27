
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_bannerBlock : Block
    {
        public override string BlockId => "minecraft:pink_banner";
        public override BlockState[] PossibleStates { get; }
        public Pink_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6932, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6933, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6934, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6935, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6936, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6937, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6938, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6939, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6940, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6941, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6942, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6943, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6944, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6945, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6946, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6947, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Pink_bannerItem() };

        }
    }
}
