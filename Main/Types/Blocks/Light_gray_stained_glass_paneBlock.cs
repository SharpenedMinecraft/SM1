
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_stained_glass_paneBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_stained_glass_pane";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_stained_glass_paneBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6058, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6059, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6060, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6061, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6062, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6063, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6064, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6065, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6066, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6067, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6068, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6069, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6070, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6071, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6072, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6073, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6074, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6075, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6076, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6077, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6078, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6079, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6080, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6081, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6082, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6083, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6084, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6085, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(6086, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(6087, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(6088, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(6089, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] { new Light_gray_stained_glass_paneItem() };

        }
    }
}
