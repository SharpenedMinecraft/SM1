
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Mossy_cobblestone_wallBlock : Block
    {
        public override string BlockId => "minecraft:mossy_cobblestone_wall";
        public override BlockState[] PossibleStates { get; }
        public Mossy_cobblestone_wallBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5183, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5184, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5185, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5186, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5187, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5188, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5189, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5190, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5191, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5192, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5193, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5194, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5195, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5196, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5197, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5198, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5199, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5200, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5201, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5202, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5203, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5204, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5205, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5206, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5207, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5208, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5209, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5210, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5211, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5212, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5213, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5214, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5215, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5216, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5217, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5218, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5219, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5220, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5221, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5222, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5223, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5224, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5225, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5226, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5227, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5228, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5229, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5230, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5231, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5232, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5233, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5234, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5235, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5236, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5237, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5238, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5239, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5240, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5241, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5242, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"waterlogged", "false"},

            {"west", "false"},
 }),

                new BlockState(5243, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "true"},
 }),

                new BlockState(5244, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "true"},

            {"west", "false"},
 }),

                new BlockState(5245, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"waterlogged", "false"},

            {"west", "true"},
 }),

                new BlockState(5246, new Dictionary<string, string>
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

            Drops = new ItemStack[] { new Mossy_cobblestone_wallItem() };

        }
    }
}
