
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class AnvilBlock : Block
    {
        public override string BlockId => "minecraft:anvil";
        public override BlockState[] PossibleStates { get; }
        public AnvilBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5549, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5550, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5551, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5552, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new AnvilItem() };

        }
    }
}
