
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class RailBlock : Block
    {
        public override string BlockId => "minecraft:rail";
        public override BlockState[] PossibleStates { get; }
        public RailBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3161, new Dictionary<string, string>
                { 
            {"shape", "north_south"},
 }),

                new BlockState(3162, new Dictionary<string, string>
                { 
            {"shape", "east_west"},
 }),

                new BlockState(3163, new Dictionary<string, string>
                { 
            {"shape", "ascending_east"},
 }),

                new BlockState(3164, new Dictionary<string, string>
                { 
            {"shape", "ascending_west"},
 }),

                new BlockState(3165, new Dictionary<string, string>
                { 
            {"shape", "ascending_north"},
 }),

                new BlockState(3166, new Dictionary<string, string>
                { 
            {"shape", "ascending_south"},
 }),

                new BlockState(3167, new Dictionary<string, string>
                { 
            {"shape", "south_east"},
 }),

                new BlockState(3168, new Dictionary<string, string>
                { 
            {"shape", "south_west"},
 }),

                new BlockState(3169, new Dictionary<string, string>
                { 
            {"shape", "north_west"},
 }),

                new BlockState(3170, new Dictionary<string, string>
                { 
            {"shape", "north_east"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new RailItem() };

        }
    }
}
