
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Wall_torchBlock : Block
    {
        public override string BlockId => "minecraft:wall_torch";
        public override BlockState[] PossibleStates { get; }
        public Wall_torchBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1113, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(1114, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(1115, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(1116, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
