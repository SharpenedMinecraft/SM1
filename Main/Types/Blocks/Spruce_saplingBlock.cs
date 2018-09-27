
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_saplingBlock : Block
    {
        public override string BlockId => "minecraft:spruce_sapling";
        public override BlockState[] PossibleStates { get; }
        public Spruce_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(23, new Dictionary<string, string>
                { 
            {"stage", "0"},
 }),

                new BlockState(24, new Dictionary<string, string>
                { 
            {"stage", "1"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Spruce_saplingItem() };

        }
    }
}
