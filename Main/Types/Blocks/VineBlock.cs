
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class VineBlock : Block
    {
        public override string BlockId => "minecraft:vine";
        public override BlockState[] PossibleStates { get; }
        public VineBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4250, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4251, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4252, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4253, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4254, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4255, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4256, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4257, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4258, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4259, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4260, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4261, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4262, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4263, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4264, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4265, new Dictionary<string, string>
                { 
            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4266, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4267, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4268, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4269, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4270, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4271, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4272, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4273, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4274, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4275, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4276, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4277, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4278, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4279, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4280, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4281, new Dictionary<string, string>
                { 
            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[31];

            Drops = new ItemStack[] { new VineItem() };

        }
    }
}
