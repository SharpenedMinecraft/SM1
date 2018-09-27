
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_barkBlock : Block
    {
        public override string BlockId => "minecraft:birch_bark";
        public override BlockState[] PossibleStates { get; }
        public Birch_barkBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(114, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(115, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(116, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Birch_barkItem() };

        }
    }
}
