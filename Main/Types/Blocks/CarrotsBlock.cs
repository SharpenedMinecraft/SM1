
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CarrotsBlock : Block
    {
        public override string BlockId => "minecraft:carrots";
        public override BlockState[] PossibleStates { get; }
        public CarrotsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5269, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(5270, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(5271, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(5272, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(5273, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(5274, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(5275, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(5276, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
