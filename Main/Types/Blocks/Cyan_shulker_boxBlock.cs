
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Cyan_shulker_boxBlock : Block
    {
        public override string BlockId => "minecraft:cyan_shulker_box";
        public override BlockState[] PossibleStates { get; }
        public Cyan_shulker_boxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8253, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(8254, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(8255, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(8256, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

                new BlockState(8257, new Dictionary<string, string>
                { 
            {"facing", "up"},
 }),

                new BlockState(8258, new Dictionary<string, string>
                { 
            {"facing", "down"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new Cyan_shulker_boxItem() };

        }
    }
}
