
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_barkBlock : Block
    {
        public override string BlockId => "minecraft:spruce_bark";
        public override BlockState[] PossibleStates { get; }
        public Spruce_barkBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(111, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(112, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(113, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Spruce_barkItem() };

        }
    }
}
