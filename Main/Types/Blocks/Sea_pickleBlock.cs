
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Sea_pickleBlock : Block
    {
        public override string BlockId => "minecraft:sea_pickle";
        public override BlockState[] PossibleStates { get; }
        public Sea_pickleBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8466, new Dictionary<string, string>
                { 
            {"pickles", "1"},

            {"waterlogged", "true"},
 }),

                new BlockState(8467, new Dictionary<string, string>
                { 
            {"pickles", "1"},

            {"waterlogged", "false"},
 }),

                new BlockState(8468, new Dictionary<string, string>
                { 
            {"pickles", "2"},

            {"waterlogged", "true"},
 }),

                new BlockState(8469, new Dictionary<string, string>
                { 
            {"pickles", "2"},

            {"waterlogged", "false"},
 }),

                new BlockState(8470, new Dictionary<string, string>
                { 
            {"pickles", "3"},

            {"waterlogged", "true"},
 }),

                new BlockState(8471, new Dictionary<string, string>
                { 
            {"pickles", "3"},

            {"waterlogged", "false"},
 }),

                new BlockState(8472, new Dictionary<string, string>
                { 
            {"pickles", "4"},

            {"waterlogged", "true"},
 }),

                new BlockState(8473, new Dictionary<string, string>
                { 
            {"pickles", "4"},

            {"waterlogged", "false"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Sea_pickleItem() };

        }
    }
}
