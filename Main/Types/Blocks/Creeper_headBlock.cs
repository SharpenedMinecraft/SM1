
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Creeper_headBlock : Block
    {
        public override string BlockId => "minecraft:creeper_head";
        public override BlockState[] PossibleStates { get; }
        public Creeper_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5513, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(5514, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(5515, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(5516, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(5517, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(5518, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(5519, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(5520, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(5521, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(5522, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(5523, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(5524, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(5525, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(5526, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(5527, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(5528, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Creeper_headItem() };

        }
    }
}
