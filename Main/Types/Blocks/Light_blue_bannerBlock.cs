
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_blue_bannerBlock : Block
    {
        public override string BlockId => "minecraft:light_blue_banner";
        public override BlockState[] PossibleStates { get; }
        public Light_blue_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6884, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6885, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6886, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6887, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6888, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6889, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6890, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6891, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6892, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6893, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6894, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6895, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6896, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6897, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6898, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6899, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_blue_bannerItem() };

        }
    }
}
