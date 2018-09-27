
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Rose_bushBlock : Block
    {
        public override string BlockId => "minecraft:rose_bush";
        public override BlockState[] PossibleStates { get; }
        public Rose_bushBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6828, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(6829, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Rose_bushItem() };

        }
    }
}
