
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Wither_skeleton_wall_skullBlock : Block
    {
        public override string BlockId => "minecraft:wither_skeleton_wall_skull";
        public override BlockState[] PossibleStates { get; }
        public Wither_skeleton_wall_skullBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5449, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5450, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5451, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5452, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
