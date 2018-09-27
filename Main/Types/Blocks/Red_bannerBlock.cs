
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_bannerBlock : Block
    {
        public override string BlockId => "minecraft:red_banner";
        public override BlockState[] PossibleStates { get; }
        public Red_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7060, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(7061, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(7062, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(7063, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(7064, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(7065, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(7066, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(7067, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(7068, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(7069, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(7070, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(7071, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(7072, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(7073, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(7074, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(7075, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_bannerItem() };

        }
    }
}
