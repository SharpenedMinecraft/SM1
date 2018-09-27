
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Attached_pumpkin_stemBlock : Block
    {
        public override string BlockId => "minecraft:attached_pumpkin_stem";
        public override BlockState[] PossibleStates { get; }
        public Attached_pumpkin_stemBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4226, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(4227, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(4228, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(4229, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
