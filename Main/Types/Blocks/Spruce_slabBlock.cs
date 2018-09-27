
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Spruce_slabBlock : Block
    {
        public override string BlockId => "minecraft:spruce_slab";
        public override BlockState[] PossibleStates { get; }
        public Spruce_slabBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7245, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "true"},
 }),

                new BlockState(7246, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "false"},
 }),

                new BlockState(7247, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "true"},
 }),

                new BlockState(7248, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "false"},
 }),

                new BlockState(7249, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "true"},
 }),

                new BlockState(7250, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Spruce_slabItem() };

        }
    }
}
