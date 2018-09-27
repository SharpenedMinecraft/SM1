
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_bannerBlock : Block
    {
        public override string BlockId => "minecraft:cyan_banner";
        public override BlockState[] PossibleStates { get; }
        public Cyan_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6980, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6981, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6982, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6983, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6984, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6985, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6986, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6987, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6988, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6989, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6990, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6991, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6992, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6993, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6994, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6995, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Cyan_bannerItem() };

        }
    }
}
