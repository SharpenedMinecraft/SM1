
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Zombie_headBlock : Block
    {
        public override string BlockId => "minecraft:zombie_head";
        public override BlockState[] PossibleStates { get; }
        public Zombie_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5473, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(5474, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(5475, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(5476, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(5477, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(5478, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(5479, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(5480, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(5481, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(5482, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(5483, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(5484, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(5485, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(5486, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(5487, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(5488, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Zombie_headItem() };

        }
    }
}
