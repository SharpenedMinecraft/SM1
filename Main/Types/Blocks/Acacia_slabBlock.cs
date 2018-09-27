
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Acacia_slabBlock : Block
    {
        public override string BlockId => "minecraft:acacia_slab";
        public override BlockState[] PossibleStates { get; }
        public Acacia_slabBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7263, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "true"},
 }),

                new BlockState(7264, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "false"},
 }),

                new BlockState(7265, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "true"},
 }),

                new BlockState(7266, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "false"},
 }),

                new BlockState(7267, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "true"},
 }),

                new BlockState(7268, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Acacia_slabItem() };

        }
    }
}
