
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Carved_pumpkinBlock : Block
    {
        public override string BlockId => "minecraft:carved_pumpkin";
        public override BlockState[] PossibleStates { get; }
        public Carved_pumpkinBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3480, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(3481, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(3482, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(3483, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Carved_pumpkinItem() };

        }
    }
}
