
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Birch_slabBlock : Block
    {
        public override string BlockId => "minecraft:birch_slab";
        public override BlockState[] PossibleStates { get; }
        public Birch_slabBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7251, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "true"},
 }),

                new BlockState(7252, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "false"},
 }),

                new BlockState(7253, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "true"},
 }),

                new BlockState(7254, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "false"},
 }),

                new BlockState(7255, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "true"},
 }),

                new BlockState(7256, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Birch_slabItem() };

        }
    }
}
