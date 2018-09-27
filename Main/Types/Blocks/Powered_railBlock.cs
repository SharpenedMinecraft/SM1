
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Powered_railBlock : Block
    {
        public override string BlockId => "minecraft:powered_rail";
        public override BlockState[] PossibleStates { get; }
        public Powered_railBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(986, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "north_south"},
 }),

                new BlockState(987, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "east_west"},
 }),

                new BlockState(988, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_east"},
 }),

                new BlockState(989, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_west"},
 }),

                new BlockState(990, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_north"},
 }),

                new BlockState(991, new Dictionary<string, string>
                { 
            {"powered", "true"},

            {"shape", "ascending_south"},
 }),

                new BlockState(992, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "north_south"},
 }),

                new BlockState(993, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "east_west"},
 }),

                new BlockState(994, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_east"},
 }),

                new BlockState(995, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_west"},
 }),

                new BlockState(996, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_north"},
 }),

                new BlockState(997, new Dictionary<string, string>
                { 
            {"powered", "false"},

            {"shape", "ascending_south"},
 }),

            };
            State = PossibleStates[6];

            Drops = new ItemStack[] { new Powered_railItem() };

        }
    }
}
