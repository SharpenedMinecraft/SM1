
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Dark_oak_barkBlock : Block
    {
        public override string BlockId => "minecraft:dark_oak_bark";
        public override BlockState[] PossibleStates { get; }
        public Dark_oak_barkBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(123, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(124, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(125, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Dark_oak_barkItem() };

        }
    }
}
