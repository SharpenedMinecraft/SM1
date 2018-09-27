
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_bannerBlock : Block
    {
        public override string BlockId => "minecraft:brown_banner";
        public override BlockState[] PossibleStates { get; }
        public Brown_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7028, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(7029, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(7030, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(7031, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(7032, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(7033, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(7034, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(7035, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(7036, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(7037, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(7038, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(7039, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(7040, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(7041, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(7042, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(7043, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_bannerItem() };

        }
    }
}
