
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class LilacBlock : Block
    {
        public override string BlockId => "minecraft:lilac";
        public override BlockState[] PossibleStates { get; }
        public LilacBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6826, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(6827, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new LilacItem() };

        }
    }
}
