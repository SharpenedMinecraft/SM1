
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_fenceBlock : Block
    {
        public override string BlockId => "minecraft:spruce_fence";
        public override BlockState[] PossibleStates { get; }
        public Spruce_fenceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7499, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7500, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7501, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7502, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7503, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7504, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7505, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7506, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7507, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7508, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7509, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7510, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7511, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7512, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7513, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7514, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7515, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7516, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7517, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7518, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7519, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7520, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7521, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7522, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7523, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7524, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7525, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7526, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7527, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7528, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7529, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7530, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] { new Spruce_fenceItem() };

        }
    }
}
