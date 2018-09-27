
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:red_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Red_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7148, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7149, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7150, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7151, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
