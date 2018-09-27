
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8193, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8194, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8195, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8196, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8197, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8198, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Shulker_boxItem() };

        }
    }
}
