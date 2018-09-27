
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Turtle_eggBlock : Block
    {
        public override string BlockId => "minecraft:turtle_egg";
        public override BlockState[] PossibleStates { get; }
        public Turtle_eggBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8419, new Dictionary<string, string>
                { 
            {"eggs", "1"},

            {"hatch", "0"},
 }),

                new BlockState(8420, new Dictionary<string, string>
                { 
            {"eggs", "1"},

            {"hatch", "1"},
 }),

                new BlockState(8421, new Dictionary<string, string>
                { 
            {"eggs", "1"},

            {"hatch", "2"},
 }),

                new BlockState(8422, new Dictionary<string, string>
                { 
            {"eggs", "2"},

            {"hatch", "0"},
 }),

                new BlockState(8423, new Dictionary<string, string>
                { 
            {"eggs", "2"},

            {"hatch", "1"},
 }),

                new BlockState(8424, new Dictionary<string, string>
                { 
            {"eggs", "2"},

            {"hatch", "2"},
 }),

                new BlockState(8425, new Dictionary<string, string>
                { 
            {"eggs", "3"},

            {"hatch", "0"},
 }),

                new BlockState(8426, new Dictionary<string, string>
                { 
            {"eggs", "3"},

            {"hatch", "1"},
 }),

                new BlockState(8427, new Dictionary<string, string>
                { 
            {"eggs", "3"},

            {"hatch", "2"},
 }),

                new BlockState(8428, new Dictionary<string, string>
                { 
            {"eggs", "4"},

            {"hatch", "0"},
 }),

                new BlockState(8429, new Dictionary<string, string>
                { 
            {"eggs", "4"},

            {"hatch", "1"},
 }),

                new BlockState(8430, new Dictionary<string, string>
                { 
            {"eggs", "4"},

            {"hatch", "2"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Turtle_eggItem() };

        }
    }
}
