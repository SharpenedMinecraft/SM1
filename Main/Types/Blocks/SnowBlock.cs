
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class SnowBlock : Block
    {
        public override string BlockId => "minecraft:snow";
        public override BlockState[] PossibleStates { get; }
        public SnowBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3397, new Dictionary<string, string>
                { 
            {"layers", "1"},
 }),

                new BlockState(3398, new Dictionary<string, string>
                { 
            {"layers", "2"},
 }),

                new BlockState(3399, new Dictionary<string, string>
                { 
            {"layers", "3"},
 }),

                new BlockState(3400, new Dictionary<string, string>
                { 
            {"layers", "4"},
 }),

                new BlockState(3401, new Dictionary<string, string>
                { 
            {"layers", "5"},
 }),

                new BlockState(3402, new Dictionary<string, string>
                { 
            {"layers", "6"},
 }),

                new BlockState(3403, new Dictionary<string, string>
                { 
            {"layers", "7"},
 }),

                new BlockState(3404, new Dictionary<string, string>
                { 
            {"layers", "8"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new SnowItem() };

        }
    }
}
