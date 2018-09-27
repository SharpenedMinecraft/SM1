
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Structure_blockBlock : Block
    {
        public override string BlockId => "minecraft:structure_block";
        public override BlockState[] PossibleStates { get; }
        public Structure_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8480, new Dictionary<string, string>
                { 
            {"mode", "save"},
 }),

                new BlockState(8481, new Dictionary<string, string>
                { 
            {"mode", "load"},
 }),

                new BlockState(8482, new Dictionary<string, string>
                { 
            {"mode", "corner"},
 }),

                new BlockState(8483, new Dictionary<string, string>
                { 
            {"mode", "data"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Structure_blockItem() };

        }
    }
}
