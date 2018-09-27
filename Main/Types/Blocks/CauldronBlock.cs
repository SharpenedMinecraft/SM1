
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CauldronBlock : Block
    {
        public override string BlockId => "minecraft:cauldron";
        public override BlockState[] PossibleStates { get; }
        public CauldronBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4603, new Dictionary<string, string>
                { 
            {"level", "0"},
 }),

                new BlockState(4604, new Dictionary<string, string>
                { 
            {"level", "1"},
 }),

                new BlockState(4605, new Dictionary<string, string>
                { 
            {"level", "2"},
 }),

                new BlockState(4606, new Dictionary<string, string>
                { 
            {"level", "3"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new CauldronItem() };

        }
    }
}
