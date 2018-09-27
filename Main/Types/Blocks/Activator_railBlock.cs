
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Activator_railBlock : Block
    {
        public override string BlockId => "minecraft:activator_rail";
        public override BlockState[] PossibleStates { get; }
        public Activator_railBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5762, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "north_south"},
 }),

                new BlockState(5763, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "east_west"},
 }),

                new BlockState(5764, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_east"},
 }),

                new BlockState(5765, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_west"},
 }),

                new BlockState(5766, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_north"},
 }),

                new BlockState(5767, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_south"},
 }),

                new BlockState(5768, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "north_south"},
 }),

                new BlockState(5769, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "east_west"},
 }),

                new BlockState(5770, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_east"},
 }),

                new BlockState(5771, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_west"},
 }),

                new BlockState(5772, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_north"},
 }),

                new BlockState(5773, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_south"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Activator_railItem() };

        }
    }
}
