
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Redstone_wall_torchBlock : Block
    {
        public override string BlockId => "minecraft:redstone_wall_torch";
        public override BlockState[] PossibleStates { get; }
        public Redstone_wall_torchBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3365, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"lit", "true"},
 }),

                new BlockState(3366, new Dictionary<string, string>
                { 
            {"facing", "north"},

            {"lit", "false"},
 }),

                new BlockState(3367, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"lit", "true"},
 }),

                new BlockState(3368, new Dictionary<string, string>
                { 
            {"facing", "east"},

            {"lit", "false"},
 }),

                new BlockState(3369, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"lit", "true"},
 }),

                new BlockState(3370, new Dictionary<string, string>
                { 
            {"facing", "south"},

            {"lit", "false"},
 }),

                new BlockState(3371, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"lit", "true"},
 }),

                new BlockState(3372, new Dictionary<string, string>
                { 
            {"facing", "west"},

            {"lit", "false"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
