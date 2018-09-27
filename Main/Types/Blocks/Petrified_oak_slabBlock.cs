
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Petrified_oak_slabBlock : Block
    {
        public override string BlockId => "minecraft:petrified_oak_slab";
        public override BlockState[] PossibleStates { get; }
        public Petrified_oak_slabBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7287, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "true"},
 }),

                new BlockState(7288, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "false"},
 }),

                new BlockState(7289, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "true"},
 }),

                new BlockState(7290, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "false"},
 }),

                new BlockState(7291, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "true"},
 }),

                new BlockState(7292, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Petrified_oak_slabItem() };

        }
    }
}
