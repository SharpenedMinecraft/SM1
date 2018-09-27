
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_bannerBlock : Block
    {
        public override string BlockId => "minecraft:magenta_banner";
        public override BlockState[] PossibleStates { get; }
        public Magenta_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6868, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6869, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6870, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6871, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6872, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6873, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6874, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6875, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6876, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6877, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6878, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6879, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6880, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6881, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6882, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6883, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Magenta_bannerItem() };

        }
    }
}
