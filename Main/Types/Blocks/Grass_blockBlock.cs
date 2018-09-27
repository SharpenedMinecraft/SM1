
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Grass_blockBlock : Block
    {
        public override string BlockId => "minecraft:grass_block";
        public override BlockState[] PossibleStates { get; }
        public Grass_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8, new Dictionary<string, string>
                { 
            {"snowy", "true"},
 }),

                new BlockState(9, new Dictionary<string, string>
                { 
            {"snowy", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Grass_blockItem() };

        }
    }
}
