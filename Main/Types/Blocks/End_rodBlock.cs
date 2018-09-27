
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class End_rodBlock : Block
    {
        public override string BlockId => "minecraft:end_rod";
        public override BlockState[] PossibleStates { get; }
        public End_rodBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7979, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(7980, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(7981, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(7982, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(7983, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(7984, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new End_rodItem() };

        }
    }
}
