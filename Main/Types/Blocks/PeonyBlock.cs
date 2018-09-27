
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PeonyBlock : Block
    {
        public override string BlockId => "minecraft:peony";
        public override BlockState[] PossibleStates { get; }
        public PeonyBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6830, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(6831, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new PeonyItem() };

        }
    }
}
