
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:gray_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Gray_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7120, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7121, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7122, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7123, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
