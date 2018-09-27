
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class ObserverBlock : Block
    {
        public override string BlockId => "minecraft:observer";
        public override BlockState[] PossibleStates { get; }
        public ObserverBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8181, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"powered", "true"},
 }),

                new BlockState(8182, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"powered", "false"},
 }),

                new BlockState(8183, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"powered", "true"},
 }),

                new BlockState(8184, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"powered", "false"},
 }),

                new BlockState(8185, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"powered", "true"},
 }),

                new BlockState(8186, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"powered", "false"},
 }),

                new BlockState(8187, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"powered", "true"},
 }),

                new BlockState(8188, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"powered", "false"},
 }),

                new BlockState(8189, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"powered", "true"},
 }),

                new BlockState(8190, new Dictionary<string, string>
                { 
            {"facing", "up"},

            {"powered", "false"},
 }),

                new BlockState(8191, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"powered", "true"},
 }),

                new BlockState(8192, new Dictionary<string, string>
                { 
            {"facing", "down"},

            {"powered", "false"},
 }),

            };
            State = PossibleStates[5];

            Drops = new ItemStack[] { new ObserverItem() };

        }
    }
}
