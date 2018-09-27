
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Orange_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:orange_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Orange_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8205, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8206, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8207, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8208, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8209, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8210, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Orange_shulker_boxItem() };

        }
    }
}
