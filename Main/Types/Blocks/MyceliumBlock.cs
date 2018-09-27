
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class MyceliumBlock : Block
    {
        public override string BlockId => "minecraft:mycelium";
        public override BlockState[] PossibleStates { get; }
        public MyceliumBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4474, new Dictionary<string, string>
                { 
            {"snowy", "true"},
 }),

                new BlockState(4475, new Dictionary<string, string>
                { 
            {"snowy", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new MyceliumItem() };

        }
    }
}
