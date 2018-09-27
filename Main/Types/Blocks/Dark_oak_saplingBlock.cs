
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_saplingBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_sapling";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(31, new Dictionary<string, string>
                { 
            {"stage", "0"},
 }),

                new BlockState(32, new Dictionary<string, string>
                { 
            {"stage", "1"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Dark_oak_saplingItem() };

        }
    }
}
