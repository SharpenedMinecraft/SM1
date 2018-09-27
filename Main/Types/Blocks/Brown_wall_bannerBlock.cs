
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:brown_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Brown_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7140, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7141, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7142, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7143, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
