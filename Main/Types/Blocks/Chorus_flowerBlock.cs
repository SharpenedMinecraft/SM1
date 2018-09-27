
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chorus_flowerBlock : Block
    {
        public override string BlockId => "minecraft:chorus_flower";
        public override BlockState[] PossibleStates { get; }
        public Chorus_flowerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8049, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(8050, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(8051, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(8052, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(8053, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(8054, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Chorus_flowerItem() };

        }
    }
}
