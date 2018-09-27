
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Black_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:black_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Black_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8289, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8290, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8291, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8292, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8293, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8294, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Black_shulker_boxItem() };

        }
    }
}
