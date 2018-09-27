
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Tube_coral_fanBlock : Block
    {
        public override string BlockId => "minecraft:tube_coral_fan";
        public override BlockState[] PossibleStates { get; }
        public Tube_coral_fanBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8446, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8447, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8448, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8449, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Tube_coral_fanItem() };

        }
    }
}
