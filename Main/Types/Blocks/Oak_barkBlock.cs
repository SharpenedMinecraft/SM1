
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_barkBlock : Block
    {
        public override string BlockId => "minecraft:oak_bark";
        public override BlockState[] PossibleStates { get; }
        public Oak_barkBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(108, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(109, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(110, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Oak_barkItem() };

        }
    }
}
