
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_glazed_terracottaBlock : Block
    {
        public override string BlockId => "minecraft:red_glazed_terracotta";
        public override BlockState[] PossibleStates { get; }
        public Red_glazed_terracottaBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8351, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8352, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8353, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8354, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Red_glazed_terracottaItem() };

        }
    }
}
