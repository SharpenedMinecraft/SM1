
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Gray_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:gray_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Gray_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8241, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8242, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8243, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8244, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8245, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8246, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Gray_shulker_boxItem() };

        }
    }
}
