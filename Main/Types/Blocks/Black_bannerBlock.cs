
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_bannerBlock : Block
    {
        public override string BlockId => "minecraft:black_banner";
        public override BlockState[] PossibleStates { get; }
        public Black_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7076, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(7077, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(7078, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(7079, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(7080, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(7081, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(7082, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(7083, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(7084, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(7085, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(7086, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(7087, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(7088, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(7089, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(7090, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(7091, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Black_bannerItem() };

        }
    }
}
