
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purple_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:purple_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Purple_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7132, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7133, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7134, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7135, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
