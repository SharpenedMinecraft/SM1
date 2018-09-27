
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Bone_blockBlock : Block
    {
        public override string BlockId => "minecraft:bone_block";
        public override BlockState[] PossibleStates { get; }
        public Bone_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8177, new Dictionary<string, string>
                { 
            {"axis", "x"},
 }),

                new BlockState(8178, new Dictionary<string, string>
                { 
            {"axis", "y"},
 }),

                new BlockState(8179, new Dictionary<string, string>
                { 
            {"axis", "z"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new Bone_blockItem() };

        }
    }
}
