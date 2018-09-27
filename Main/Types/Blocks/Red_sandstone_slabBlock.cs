
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_sandstone_slabBlock : Block
    {
        public override string BlockId => "minecraft:red_sandstone_slab";
        public override BlockState[] PossibleStates { get; }
        public Red_sandstone_slabBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7323, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "true"},
 }),

                new BlockState(7324, new Dictionary<string, string>
                { 
            {"type", "top"},

            {"waterlogged", "false"},
 }),

                new BlockState(7325, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "true"},
 }),

                new BlockState(7326, new Dictionary<string, string>
                { 
            {"type", "bottom"},

            {"waterlogged", "false"},
 }),

                new BlockState(7327, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "true"},
 }),

                new BlockState(7328, new Dictionary<string, string>
                { 
            {"type", "double"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[3];

            Drops = new ItemStack[] { new Red_sandstone_slabItem() };

        }
    }
}
