
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Attached_melon_stemBlock : Block
    {
        public override string BlockId => "minecraft:attached_melon_stem";
        public override BlockState[] PossibleStates { get; }
        public Attached_melon_stemBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4230, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(4231, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(4232, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(4233, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
