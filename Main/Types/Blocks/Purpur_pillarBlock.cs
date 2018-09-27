
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Purpur_pillarBlock : Block
    {
        public override string BlockId => "minecraft:purpur_pillar";
        public override BlockState[] PossibleStates { get; }
        public Purpur_pillarBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8056, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(8057, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(8058, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Purpur_pillarItem() };

        }
    }
}
