
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Zombie_wall_headBlock : Block
    {
        public override string BlockId => "minecraft:zombie_wall_head";
        public override BlockState[] PossibleStates { get; }
        public Zombie_wall_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5469, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5470, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5471, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5472, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
