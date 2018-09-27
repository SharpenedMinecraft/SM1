
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:pink_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Pink_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7116, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7117, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7118, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7119, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
