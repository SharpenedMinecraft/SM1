
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chipped_anvilBlock : Block
    {
        public override string BlockId => "minecraft:chipped_anvil";
        public override BlockState[] PossibleStates { get; }
        public Chipped_anvilBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5553, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5554, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5555, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5556, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Chipped_anvilItem() };

        }
    }
}
