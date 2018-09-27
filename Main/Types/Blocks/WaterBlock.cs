
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class WaterBlock : Block
    {
        public override string BlockId => "minecraft:water";
        public override BlockState[] PossibleStates { get; }
        public WaterBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(34, new Dictionary<string, string>
                { 
            {"level", "0"},
 }),

                new BlockState(35, new Dictionary<string, string>
                { 
            {"level", "1"},
 }),

                new BlockState(36, new Dictionary<string, string>
                { 
            {"level", "2"},
 }),

                new BlockState(37, new Dictionary<string, string>
                { 
            {"level", "3"},
 }),

                new BlockState(38, new Dictionary<string, string>
                { 
            {"level", "4"},
 }),

                new BlockState(39, new Dictionary<string, string>
                { 
            {"level", "5"},
 }),

                new BlockState(40, new Dictionary<string, string>
                { 
            {"level", "6"},
 }),

                new BlockState(41, new Dictionary<string, string>
                { 
            {"level", "7"},
 }),

                new BlockState(42, new Dictionary<string, string>
                { 
            {"level", "8"},
 }),

                new BlockState(43, new Dictionary<string, string>
                { 
            {"level", "9"},
 }),

                new BlockState(44, new Dictionary<string, string>
                { 
            {"level", "10"},
 }),

                new BlockState(45, new Dictionary<string, string>
                { 
            {"level", "11"},
 }),

                new BlockState(46, new Dictionary<string, string>
                { 
            {"level", "12"},
 }),

                new BlockState(47, new Dictionary<string, string>
                { 
            {"level", "13"},
 }),

                new BlockState(48, new Dictionary<string, string>
                { 
            {"level", "14"},
 }),

                new BlockState(49, new Dictionary<string, string>
                { 
            {"level", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
