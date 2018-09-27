
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cobblestone_wallBlock : Block
    {
        public override string BlockId => "minecraft:cobblestone_wall";
        public override BlockState[] PossibleStates { get; }
        public Cobblestone_wallBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5119, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5120, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5121, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5122, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5123, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5124, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5125, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5126, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5127, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5128, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5129, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5130, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5131, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5132, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5133, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5134, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5135, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5136, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5137, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5138, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5139, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5140, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5141, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5142, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5143, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5144, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5145, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5146, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5147, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5148, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5149, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5150, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5151, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5152, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5153, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5154, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5155, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5156, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5157, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5158, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5159, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5160, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5161, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5162, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5163, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5164, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5165, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5166, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5167, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5168, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5169, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5170, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5171, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5172, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5173, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5174, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5175, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5176, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5177, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5178, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5179, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5180, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5181, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5182, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[59];

            Drops = new ItemStack[] { new Cobblestone_wallItem() };

        }
    }
}
