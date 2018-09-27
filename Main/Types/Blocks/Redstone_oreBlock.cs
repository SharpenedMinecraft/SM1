
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Redstone_oreBlock : Block
    {
        public override string BlockId => "minecraft:redstone_ore";
        public override BlockState[] PossibleStates { get; }
        public Redstone_oreBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3361, new Dictionary<string, string>
                { 
            {"lit", "true"},
 }),

                new BlockState(3362, new Dictionary<string, string>
                { 
            {"lit", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Redstone_oreItem() };

        }
    }
}
