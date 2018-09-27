
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:green_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Green_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7144, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7145, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7146, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7147, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
