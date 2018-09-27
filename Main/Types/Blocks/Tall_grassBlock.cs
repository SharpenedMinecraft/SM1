
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Tall_grassBlock : Block
    {
        public override string BlockId => "minecraft:tall_grass";
        public override BlockState[] PossibleStates { get; }
        public Tall_grassBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6832, new Dictionary<string, string>
                { 
            {"half", "upper"},
 }),

                new BlockState(6833, new Dictionary<string, string>
                { 
            {"half", "lower"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Tall_grassItem() };

        }
    }
}
