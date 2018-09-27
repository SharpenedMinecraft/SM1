
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:yellow_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Yellow_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7108, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7109, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7110, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7111, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
