
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class BeetrootsBlock : Block
    {
        public override string BlockId => "minecraft:beetroots";
        public override BlockState[] PossibleStates { get; }
        public BeetrootsBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8140, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(8141, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(8142, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(8143, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
