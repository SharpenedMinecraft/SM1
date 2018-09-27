
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_barkBlock : Block
    {
        public override string BlockId => "minecraft:acacia_bark";
        public override BlockState[] PossibleStates { get; }
        public Acacia_barkBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(120, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(121, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(122, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Acacia_barkItem() };

        }
    }
}
