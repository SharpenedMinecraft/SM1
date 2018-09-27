
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brewing_standBlock : Block
    {
        public override string BlockId => "minecraft:brewing_stand";
        public override BlockState[] PossibleStates { get; }
        public Brewing_standBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4595, new Dictionary<string, string>
                { 
            {"has_bottle_0", "true"},

            {"has_bottle_1", "true"},

            {"has_bottle_2", "true"},
 }),

                new BlockState(4596, new Dictionary<string, string>
                { 
            {"has_bottle_0", "true"},

            {"has_bottle_1", "true"},

            {"has_bottle_2", "false"},
 }),

                new BlockState(4597, new Dictionary<string, string>
                { 
            {"has_bottle_0", "true"},

            {"has_bottle_1", "false"},

            {"has_bottle_2", "true"},
 }),

                new BlockState(4598, new Dictionary<string, string>
                { 
            {"has_bottle_0", "true"},

            {"has_bottle_1", "false"},

            {"has_bottle_2", "false"},
 }),

                new BlockState(4599, new Dictionary<string, string>
                { 
            {"has_bottle_0", "false"},

            {"has_bottle_1", "true"},

            {"has_bottle_2", "true"},
 }),

                new BlockState(4600, new Dictionary<string, string>
                { 
            {"has_bottle_0", "false"},

            {"has_bottle_1", "true"},

            {"has_bottle_2", "false"},
 }),

                new BlockState(4601, new Dictionary<string, string>
                { 
            {"has_bottle_0", "false"},

            {"has_bottle_1", "false"},

            {"has_bottle_2", "true"},
 }),

                new BlockState(4602, new Dictionary<string, string>
                { 
            {"has_bottle_0", "false"},

            {"has_bottle_1", "false"},

            {"has_bottle_2", "false"},
 }),

            };
            State = PossibleStates[7];

            Drops = new ItemStack[] { new Brewing_standItem() };

        }
    }
}
