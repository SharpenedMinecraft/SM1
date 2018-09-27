
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:lime_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Lime_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7112, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7113, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7114, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7115, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
