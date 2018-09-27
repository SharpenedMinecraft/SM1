
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class End_portal_frameBlock : Block
    {
        public override string BlockId => "minecraft:end_portal_frame";
        public override BlockState[] PossibleStates { get; }
        public End_portal_frameBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4608, new Dictionary<string, string>
                { 
            {"eye", "true"},

            {"facing", "north"},
 }),

                new BlockState(4609, new Dictionary<string, string>
                { 
            {"eye", "true"},

            {"facing", "east"},
 }),

                new BlockState(4610, new Dictionary<string, string>
                { 
            {"eye", "true"},

            {"facing", "south"},
 }),

                new BlockState(4611, new Dictionary<string, string>
                { 
            {"eye", "true"},

            {"facing", "west"},
 }),

                new BlockState(4612, new Dictionary<string, string>
                { 
            {"eye", "false"},

            {"facing", "north"},
 }),

                new BlockState(4613, new Dictionary<string, string>
                { 
            {"eye", "false"},

            {"facing", "east"},
 }),

                new BlockState(4614, new Dictionary<string, string>
                { 
            {"eye", "false"},

            {"facing", "south"},
 }),

                new BlockState(4615, new Dictionary<string, string>
                { 
            {"eye", "false"},

            {"facing", "west"},
 }),

            };
            State = PossibleStates[4];

            Drops = new ItemStack[] { new End_portal_frameItem() };

        }
    }
}
