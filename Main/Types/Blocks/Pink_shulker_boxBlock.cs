
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pink_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:pink_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Pink_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8235, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8236, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8237, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8238, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8239, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8240, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Pink_shulker_boxItem() };

        }
    }
}
