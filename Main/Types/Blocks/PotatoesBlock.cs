
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class PotatoesBlock : Block
    {
        public override string BlockId => "minecraft:potatoes";
        public override BlockState[] PossibleStates { get; }
        public PotatoesBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5277, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(5278, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(5279, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(5280, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(5281, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(5282, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(5283, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(5284, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
