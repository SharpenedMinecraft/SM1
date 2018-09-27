
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class WheatBlock : Block
    {
        public override string BlockId => "minecraft:wheat";
        public override BlockState[] PossibleStates { get; }
        public WheatBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3033, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(3034, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(3035, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(3036, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(3037, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(3038, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(3039, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(3040, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new WheatItem() };

        }
    }
}
