
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Blue_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:blue_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Blue_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7136, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7137, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7138, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7139, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
