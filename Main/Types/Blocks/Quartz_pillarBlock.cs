
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Quartz_pillarBlock : Block
    {
        public override string BlockId => "minecraft:quartz_pillar";
        public override BlockState[] PossibleStates { get; }
        public Quartz_pillarBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5679, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(5680, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(5681, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Quartz_pillarItem() };

        }
    }
}
