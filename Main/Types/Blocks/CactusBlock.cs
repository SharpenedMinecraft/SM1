
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CactusBlock : Block
    {
        public override string BlockId => "minecraft:cactus";
        public override BlockState[] PossibleStates { get; }
        public CactusBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3407, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(3408, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(3409, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(3410, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(3411, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(3412, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(3413, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(3414, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

                new BlockState(3415, new Dictionary<string, string>
                { 
            {"age", "8"},
 }),

                new BlockState(3416, new Dictionary<string, string>
                { 
            {"age", "9"},
 }),

                new BlockState(3417, new Dictionary<string, string>
                { 
            {"age", "10"},
 }),

                new BlockState(3418, new Dictionary<string, string>
                { 
            {"age", "11"},
 }),

                new BlockState(3419, new Dictionary<string, string>
                { 
            {"age", "12"},
 }),

                new BlockState(3420, new Dictionary<string, string>
                { 
            {"age", "13"},
 }),

                new BlockState(3421, new Dictionary<string, string>
                { 
            {"age", "14"},
 }),

                new BlockState(3422, new Dictionary<string, string>
                { 
            {"age", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new CactusItem() };

        }
    }
}
