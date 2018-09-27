
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Skeleton_skullBlock : Block
    {
        public override string BlockId => "minecraft:skeleton_skull";
        public override BlockState[] PossibleStates { get; }
        public Skeleton_skullBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5433, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(5434, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(5435, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(5436, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(5437, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(5438, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(5439, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(5440, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(5441, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(5442, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(5443, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(5444, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(5445, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(5446, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(5447, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(5448, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Skeleton_skullItem() };

        }
    }
}
