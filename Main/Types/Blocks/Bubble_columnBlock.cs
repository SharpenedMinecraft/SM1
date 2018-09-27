
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Bubble_columnBlock : Block
    {
        public override string BlockId => "minecraft:bubble_column";
        public override BlockState[] PossibleStates { get; }
        public Bubble_columnBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8478, new Dictionary<string, string>
                { 
            {"drag", "true"},
 }),

                new BlockState(8479, new Dictionary<string, string>
                { 
            {"drag", "false"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
