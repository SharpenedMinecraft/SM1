
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Melon_stemBlock : Block
    {
        public override string BlockId => "minecraft:melon_stem";
        public override BlockState[] PossibleStates { get; }
        public Melon_stemBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4242, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(4243, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(4244, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(4245, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(4246, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(4247, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(4248, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(4249, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
