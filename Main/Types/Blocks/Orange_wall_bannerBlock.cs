
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:orange_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Orange_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7096, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7097, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7098, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7099, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
