
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_fenceBlock : Block
    {
        public override string BlockId => "minecraft:birch_fence";
        public override BlockState[] PossibleStates { get; }
        public Birch_fenceBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7531, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7532, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7533, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7534, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7535, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7536, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7537, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7538, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7539, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7540, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7541, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7542, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7543, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7544, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7545, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7546, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7547, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7548, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7549, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7550, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7551, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7552, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7553, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7554, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7555, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7556, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7557, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7558, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(7559, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(7560, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(7561, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(7562, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] { new Birch_fenceItem() };

        }
    }
}
