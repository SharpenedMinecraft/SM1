
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Player_headBlock : Block
    {
        public override string BlockId => "minecraft:player_head";
        public override BlockState[] PossibleStates { get; }
        public Player_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5493, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(5494, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(5495, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(5496, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(5497, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(5498, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(5499, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(5500, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(5501, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(5502, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(5503, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(5504, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(5505, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(5506, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(5507, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(5508, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Player_headItem() };

        }
    }
}
