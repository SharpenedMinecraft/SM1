
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Skeleton_wall_skullBlock : Block
    {
        public override string BlockId => "minecraft:skeleton_wall_skull";
        public override BlockState[] PossibleStates { get; }
        public Skeleton_wall_skullBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5429, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5430, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5431, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5432, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
