
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_saplingBlock : Block
    {
        public override string BlockId => "minecraft:birch_sapling";
        public override BlockState[] PossibleStates { get; }
        public Birch_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(25, new Dictionary<string, string>
                { 
            {"stage", "0"},
 }),

                new BlockState(26, new Dictionary<string, string>
                { 
            {"stage", "1"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Birch_saplingItem() };

        }
    }
}
