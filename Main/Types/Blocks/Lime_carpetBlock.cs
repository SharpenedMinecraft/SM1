
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Lime_carpetBlock : Block
    {
        public override string BlockId => "minecraft:lime_carpet";
        public override BlockState[] PossibleStates { get; }
        public Lime_carpetBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(6810, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Lime_carpetItem() };

        }
    }
}
