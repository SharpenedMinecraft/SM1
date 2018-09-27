
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_stained_glass_paneBlock : Block
    {
        public override string BlockId => "minecraft:magenta_stained_glass_pane";
        public override BlockState[] PossibleStates { get; }
        public Magenta_stained_glass_paneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5866, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5867, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5868, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5869, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5870, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5871, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5872, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5873, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5874, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5875, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5876, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5877, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5878, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5879, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5880, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5881, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5882, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5883, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5884, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5885, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5886, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5887, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5888, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5889, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5890, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5891, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5892, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5893, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5894, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5895, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5896, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5897, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] { new Magenta_stained_glass_paneItem() };

        }
    }
}
