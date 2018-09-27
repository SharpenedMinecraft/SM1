
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_stained_glass_paneBlock : Block
    {
        public override string BlockId => "minecraft:white_stained_glass_pane";
        public override BlockState[] PossibleStates { get; }
        public White_stained_glass_paneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5802, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5803, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5804, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5805, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5806, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5807, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5808, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5809, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5810, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5811, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5812, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5813, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5814, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5815, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5816, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5817, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5818, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5819, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5820, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5821, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5822, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5823, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5824, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5825, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5826, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5827, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5828, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5829, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5830, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5831, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5832, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5833, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] { new White_stained_glass_paneItem() };

        }
    }
}
