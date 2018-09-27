
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Magenta_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:magenta_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Magenta_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7100, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7101, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7102, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7103, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
