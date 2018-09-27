
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Hay_blockBlock : Block
    {
        public override string BlockId => "minecraft:hay_block";
        public override BlockState[] PossibleStates { get; }
        public Hay_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6802, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(6803, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(6804, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Hay_blockItem() };

        }
    }
}
