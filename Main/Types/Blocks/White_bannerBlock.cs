
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_bannerBlock : Block
    {
        public override string BlockId => "minecraft:white_banner";
        public override BlockState[] PossibleStates { get; }
        public White_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6836, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6837, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6838, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6839, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6840, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6841, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6842, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6843, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6844, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6845, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6846, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6847, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6848, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6849, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6850, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6851, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new White_bannerItem() };

        }
    }
}
