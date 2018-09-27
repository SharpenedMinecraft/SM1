
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_blue_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:light_blue_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Light_blue_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7104, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7105, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7106, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7107, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
