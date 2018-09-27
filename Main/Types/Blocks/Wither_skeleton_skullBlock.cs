
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Wither_skeleton_skullBlock : Block
    {
        public override string BlockId => "minecraft:wither_skeleton_skull";
        public override BlockState[] PossibleStates { get; }
        public Wither_skeleton_skullBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5453, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(5454, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(5455, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(5456, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(5457, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(5458, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(5459, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(5460, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(5461, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(5462, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(5463, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(5464, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(5465, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(5466, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(5467, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(5468, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Wither_skeleton_skullItem() };

        }
    }
}
