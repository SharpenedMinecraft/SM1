
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:black_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Black_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7152, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7153, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7154, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7155, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
