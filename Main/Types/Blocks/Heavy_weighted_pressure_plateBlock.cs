
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Heavy_weighted_pressure_plateBlock : Block
    {
        public override string BlockId => "minecraft:heavy_weighted_pressure_plate";
        public override BlockState[] PossibleStates { get; }
        public Heavy_weighted_pressure_plateBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5601, new Dictionary<string, string>
                { 
            {"power", "0"},
 }),

                new BlockState(5602, new Dictionary<string, string>
                { 
            {"power", "1"},
 }),

                new BlockState(5603, new Dictionary<string, string>
                { 
            {"power", "2"},
 }),

                new BlockState(5604, new Dictionary<string, string>
                { 
            {"power", "3"},
 }),

                new BlockState(5605, new Dictionary<string, string>
                { 
            {"power", "4"},
 }),

                new BlockState(5606, new Dictionary<string, string>
                { 
            {"power", "5"},
 }),

                new BlockState(5607, new Dictionary<string, string>
                { 
            {"power", "6"},
 }),

                new BlockState(5608, new Dictionary<string, string>
                { 
            {"power", "7"},
 }),

                new BlockState(5609, new Dictionary<string, string>
                { 
            {"power", "8"},
 }),

                new BlockState(5610, new Dictionary<string, string>
                { 
            {"power", "9"},
 }),

                new BlockState(5611, new Dictionary<string, string>
                { 
            {"power", "10"},
 }),

                new BlockState(5612, new Dictionary<string, string>
                { 
            {"power", "11"},
 }),

                new BlockState(5613, new Dictionary<string, string>
                { 
            {"power", "12"},
 }),

                new BlockState(5614, new Dictionary<string, string>
                { 
            {"power", "13"},
 }),

                new BlockState(5615, new Dictionary<string, string>
                { 
            {"power", "14"},
 }),

                new BlockState(5616, new Dictionary<string, string>
                { 
            {"power", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Heavy_weighted_pressure_plateItem() };

        }
    }
}
