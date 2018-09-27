
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_bannerBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_banner";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6964, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6965, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6966, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6967, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6968, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6969, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6970, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6971, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6972, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6973, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6974, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6975, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6976, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6977, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6978, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6979, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Light_gray_bannerItem() };

        }
    }
}
