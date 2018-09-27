
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Sugar_caneBlock : Block
    {
        public override string BlockId => "minecraft:sugar_cane";
        public override BlockState[] PossibleStates { get; }
        public Sugar_caneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3424, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(3425, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(3426, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(3427, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(3428, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(3429, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(3430, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(3431, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

                new BlockState(3432, new Dictionary<string, string>
                { 
            {"age", "8"},
 }),

                new BlockState(3433, new Dictionary<string, string>
                { 
            {"age", "9"},
 }),

                new BlockState(3434, new Dictionary<string, string>
                { 
            {"age", "10"},
 }),

                new BlockState(3435, new Dictionary<string, string>
                { 
            {"age", "11"},
 }),

                new BlockState(3436, new Dictionary<string, string>
                { 
            {"age", "12"},
 }),

                new BlockState(3437, new Dictionary<string, string>
                { 
            {"age", "13"},
 }),

                new BlockState(3438, new Dictionary<string, string>
                { 
            {"age", "14"},
 }),

                new BlockState(3439, new Dictionary<string, string>
                { 
            {"age", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Sugar_caneItem() };

        }
    }
}
