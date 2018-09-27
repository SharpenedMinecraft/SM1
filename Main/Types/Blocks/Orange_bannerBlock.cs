
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_bannerBlock : Block
    {
        public override string BlockId => "minecraft:orange_banner";
        public override BlockState[] PossibleStates { get; }
        public Orange_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6852, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6853, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6854, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6855, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6856, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6857, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6858, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6859, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6860, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6861, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6862, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6863, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6864, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6865, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6866, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6867, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Orange_bannerItem() };

        }
    }
}
