
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PodzolBlock : Block
    {
        public override string BlockId => "minecraft:podzol";
        public override BlockState[] PossibleStates { get; }
        public PodzolBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(12, new Dictionary<string, string>
                { 
            {"snowy", "true"},
 }),

                new BlockState(13, new Dictionary<string, string>
                { 
            {"snowy", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new PodzolItem() };

        }
    }
}
