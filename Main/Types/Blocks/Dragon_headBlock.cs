
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dragon_headBlock : Block
    {
        public override string BlockId => "minecraft:dragon_head";
        public override BlockState[] PossibleStates { get; }
        public Dragon_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5533, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(5534, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(5535, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(5536, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(5537, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(5538, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(5539, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(5540, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(5541, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(5542, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(5543, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(5544, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(5545, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(5546, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(5547, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(5548, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dragon_headItem() };

        }
    }
}
