
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_bannerBlock : Block
    {
        public override string BlockId => "minecraft:purple_banner";
        public override BlockState[] PossibleStates { get; }
        public Purple_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6996, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6997, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6998, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6999, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(7000, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(7001, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(7002, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(7003, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(7004, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(7005, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(7006, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(7007, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(7008, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(7009, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(7010, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(7011, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Purple_bannerItem() };

        }
    }
}
