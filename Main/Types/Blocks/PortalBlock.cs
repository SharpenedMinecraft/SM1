
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PortalBlock : Block
    {
        public override string BlockId => "minecraft:portal";
        public override BlockState[] PossibleStates { get; }
        public PortalBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3478, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(3479, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
