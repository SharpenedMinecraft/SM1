
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Yellow_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:yellow_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Yellow_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8223, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8224, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8225, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8226, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8227, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8228, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Yellow_shulker_boxItem() };

        }
    }
}
