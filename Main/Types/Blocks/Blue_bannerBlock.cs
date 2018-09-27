
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_bannerBlock : Block
    {
        public override string BlockId => "minecraft:blue_banner";
        public override BlockState[] PossibleStates { get; }
        public Blue_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7012, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(7013, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(7014, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(7015, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(7016, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(7017, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(7018, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(7019, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(7020, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(7021, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(7022, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(7023, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(7024, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(7025, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(7026, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(7027, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Blue_bannerItem() };

        }
    }
}
