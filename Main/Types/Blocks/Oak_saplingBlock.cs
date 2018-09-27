
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Oak_saplingBlock : Block
    {
        public override string BlockId => "minecraft:oak_sapling";
        public override BlockState[] PossibleStates { get; }
        public Oak_saplingBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(21, new Dictionary<string, string>
                { 
            {"stage", "0"},
 }),

                new BlockState(22, new Dictionary<string, string>
                { 
            {"stage", "1"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Oak_saplingItem() };

        }
    }
}
