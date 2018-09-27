
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class White_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:white_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public White_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7092, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7093, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7094, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7095, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
