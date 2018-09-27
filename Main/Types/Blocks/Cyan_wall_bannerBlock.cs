
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_wall_bannerBlock : Block
    {
        public override string BlockId => "minecraft:cyan_wall_banner";
        public override BlockState[] PossibleStates { get; }
        public Cyan_wall_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7128, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7129, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7130, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7131, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
