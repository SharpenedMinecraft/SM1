
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_bannerBlock : Block
    {
        public override string BlockId => "minecraft:yellow_banner";
        public override BlockState[] PossibleStates { get; }
        public Yellow_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6900, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6901, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6902, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6903, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6904, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6905, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6906, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6907, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6908, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6909, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6910, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6911, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6912, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6913, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6914, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6915, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Yellow_bannerItem() };

        }
    }
}
