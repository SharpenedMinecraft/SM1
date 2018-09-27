
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_weighted_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:light_weighted_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Light_weighted_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5585, new Dictionary<string, string>
                { 
            {"power", "0"},
 }),

                new BlockState(5586, new Dictionary<string, string>
                { 
            {"power", "1"},
 }),

                new BlockState(5587, new Dictionary<string, string>
                { 
            {"power", "2"},
 }),

                new BlockState(5588, new Dictionary<string, string>
                { 
            {"power", "3"},
 }),

                new BlockState(5589, new Dictionary<string, string>
                { 
            {"power", "4"},
 }),

                new BlockState(5590, new Dictionary<string, string>
                { 
            {"power", "5"},
 }),

                new BlockState(5591, new Dictionary<string, string>
                { 
            {"power", "6"},
 }),

                new BlockState(5592, new Dictionary<string, string>
                { 
            {"power", "7"},
 }),

                new BlockState(5593, new Dictionary<string, string>
                { 
            {"power", "8"},
 }),

                new BlockState(5594, new Dictionary<string, string>
                { 
            {"power", "9"},
 }),

                new BlockState(5595, new Dictionary<string, string>
                { 
            {"power", "10"},
 }),

                new BlockState(5596, new Dictionary<string, string>
                { 
            {"power", "11"},
 }),

                new BlockState(5597, new Dictionary<string, string>
                { 
            {"power", "12"},
 }),

                new BlockState(5598, new Dictionary<string, string>
                { 
            {"power", "13"},
 }),

                new BlockState(5599, new Dictionary<string, string>
                { 
            {"power", "14"},
 }),

                new BlockState(5600, new Dictionary<string, string>
                { 
            {"power", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_weighted_pressure_plateItem() };

        }
    }
}
