
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jack_o_lanternBlock : Block
    {
        public override string BlockId => "minecraft:jack_o_lantern";
        public override BlockState[] PossibleStates { get; }
        public Jack_o_lanternBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3484, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(3485, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(3486, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(3487, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Jack_o_lanternItem() };

        }
    }
}
