
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class CakeBlock : Block
    {
        public override string BlockId => "minecraft:cake";
        public override BlockState[] PossibleStates { get; }
        public CakeBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3488, new Dictionary<string, string>
                { 
            {"bites", "0"},
 }),

                new BlockState(3489, new Dictionary<string, string>
                { 
            {"bites", "1"},
 }),

                new BlockState(3490, new Dictionary<string, string>
                { 
            {"bites", "2"},
 }),

                new BlockState(3491, new Dictionary<string, string>
                { 
            {"bites", "3"},
 }),

                new BlockState(3492, new Dictionary<string, string>
                { 
            {"bites", "4"},
 }),

                new BlockState(3493, new Dictionary<string, string>
                { 
            {"bites", "5"},
 }),

                new BlockState(3494, new Dictionary<string, string>
                { 
            {"bites", "6"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new CakeItem() };

        }
    }
}
