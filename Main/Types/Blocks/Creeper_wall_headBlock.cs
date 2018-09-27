
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Creeper_wall_headBlock : Block
    {
        public override string BlockId => "minecraft:creeper_wall_head";
        public override BlockState[] PossibleStates { get; }
        public Creeper_wall_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5509, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5510, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5511, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5512, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
