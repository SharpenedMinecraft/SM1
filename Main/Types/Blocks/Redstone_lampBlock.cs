
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Redstone_lampBlock : Block
    {
        public override string BlockId => "minecraft:redstone_lamp";
        public override BlockState[] PossibleStates { get; }
        public Redstone_lampBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4618, new Dictionary<string, string>
                { 
            {"lit", "true"},
 }),

                new BlockState(4619, new Dictionary<string, string>
                { 
            {"lit", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Redstone_lampItem() };

        }
    }
}
