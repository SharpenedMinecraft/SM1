
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Redstone_torchBlock : Block
    {
        public override string BlockId => "minecraft:redstone_torch";
        public override BlockState[] PossibleStates { get; }
        public Redstone_torchBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3363, new Dictionary<string, string>
                { 
            {"lit", "true"},
 }),

                new BlockState(3364, new Dictionary<string, string>
                { 
            {"lit", "false"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Redstone_torchItem() };

        }
    }
}
