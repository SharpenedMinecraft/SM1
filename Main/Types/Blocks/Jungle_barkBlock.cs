
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_barkBlock : Block
    {
        public override string BlockId => "minecraft:jungle_bark";
        public override BlockState[] PossibleStates { get; }
        public Jungle_barkBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(117, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(118, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(119, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Jungle_barkItem() };

        }
    }
}
