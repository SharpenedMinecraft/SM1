
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dragon_wall_headBlock : Block
    {
        public override string BlockId => "minecraft:dragon_wall_head";
        public override BlockState[] PossibleStates { get; }
        public Dragon_wall_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5529, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5530, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5531, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5532, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
