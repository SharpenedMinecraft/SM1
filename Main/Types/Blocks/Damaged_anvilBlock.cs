
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Damaged_anvilBlock : Block
    {
        public override string BlockId => "minecraft:damaged_anvil";
        public override BlockState[] PossibleStates { get; }
        public Damaged_anvilBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5557, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5558, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5559, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5560, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Damaged_anvilItem() };

        }
    }
}
