
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class LavaBlock : Block
    {
        public override string BlockId => "minecraft:lava";
        public override BlockState[] PossibleStates { get; }
        public LavaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(50, new Dictionary<string, string>
                { 
            {"level", "0"},
 }),

                new BlockState(51, new Dictionary<string, string>
                { 
            {"level", "1"},
 }),

                new BlockState(52, new Dictionary<string, string>
                { 
            {"level", "2"},
 }),

                new BlockState(53, new Dictionary<string, string>
                { 
            {"level", "3"},
 }),

                new BlockState(54, new Dictionary<string, string>
                { 
            {"level", "4"},
 }),

                new BlockState(55, new Dictionary<string, string>
                { 
            {"level", "5"},
 }),

                new BlockState(56, new Dictionary<string, string>
                { 
            {"level", "6"},
 }),

                new BlockState(57, new Dictionary<string, string>
                { 
            {"level", "7"},
 }),

                new BlockState(58, new Dictionary<string, string>
                { 
            {"level", "8"},
 }),

                new BlockState(59, new Dictionary<string, string>
                { 
            {"level", "9"},
 }),

                new BlockState(60, new Dictionary<string, string>
                { 
            {"level", "10"},
 }),

                new BlockState(61, new Dictionary<string, string>
                { 
            {"level", "11"},
 }),

                new BlockState(62, new Dictionary<string, string>
                { 
            {"level", "12"},
 }),

                new BlockState(63, new Dictionary<string, string>
                { 
            {"level", "13"},
 }),

                new BlockState(64, new Dictionary<string, string>
                { 
            {"level", "14"},
 }),

                new BlockState(65, new Dictionary<string, string>
                { 
            {"level", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
