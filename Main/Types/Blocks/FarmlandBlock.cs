
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class FarmlandBlock : Block
    {
        public override string BlockId => "minecraft:farmland";
        public override BlockState[] PossibleStates { get; }
        public FarmlandBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3041, new Dictionary<string, string>
                { 
            {"moisture", "0"},
 }),

                new BlockState(3042, new Dictionary<string, string>
                { 
            {"moisture", "1"},
 }),

                new BlockState(3043, new Dictionary<string, string>
                { 
            {"moisture", "2"},
 }),

                new BlockState(3044, new Dictionary<string, string>
                { 
            {"moisture", "3"},
 }),

                new BlockState(3045, new Dictionary<string, string>
                { 
            {"moisture", "4"},
 }),

                new BlockState(3046, new Dictionary<string, string>
                { 
            {"moisture", "5"},
 }),

                new BlockState(3047, new Dictionary<string, string>
                { 
            {"moisture", "6"},
 }),

                new BlockState(3048, new Dictionary<string, string>
                { 
            {"moisture", "7"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new FarmlandItem() };

        }
    }
}
