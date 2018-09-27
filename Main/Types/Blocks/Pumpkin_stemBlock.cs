
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Pumpkin_stemBlock : Block
    {
        public override string BlockId => "minecraft:pumpkin_stem";
        public override BlockState[] PossibleStates { get; }
        public Pumpkin_stemBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4234, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(4235, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(4236, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(4237, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(4238, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(4239, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(4240, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(4241, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
