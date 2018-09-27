
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_bannerBlock : Block
    {
        public override string BlockId => "minecraft:gray_banner";
        public override BlockState[] PossibleStates { get; }
        public Gray_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6948, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(6949, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(6950, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(6951, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(6952, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(6953, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(6954, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(6955, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(6956, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(6957, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(6958, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(6959, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(6960, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(6961, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(6962, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(6963, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Gray_bannerItem() };

        }
    }
}
