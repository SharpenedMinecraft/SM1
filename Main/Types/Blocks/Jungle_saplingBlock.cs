
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Jungle_saplingBlock : Block
    {
        public override string BlockId => "minecraft:jungle_sapling";
        public override BlockState[] PossibleStates { get; }
        public Jungle_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(27, new Dictionary<string, string>
                { 
            {"stage", "0"},
 }),

                new BlockState(28, new Dictionary<string, string>
                { 
            {"stage", "1"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Jungle_saplingItem() };

        }
    }
}
