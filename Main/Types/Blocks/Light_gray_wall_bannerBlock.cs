
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Light_gray_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:light_gray_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Light_gray_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7124, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7125, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7126, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7127, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
