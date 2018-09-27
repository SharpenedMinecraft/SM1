
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Green_bannerBlock : Block
    {
        public override string BlockId => "minecraft:green_banner";
        public override BlockState[] PossibleStates { get; }
        public Green_bannerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7044, new Dictionary<string, string>
                { 
            {"rotation", "0"},
 }),

                new BlockState(7045, new Dictionary<string, string>
                { 
            {"rotation", "1"},
 }),

                new BlockState(7046, new Dictionary<string, string>
                { 
            {"rotation", "2"},
 }),

                new BlockState(7047, new Dictionary<string, string>
                { 
            {"rotation", "3"},
 }),

                new BlockState(7048, new Dictionary<string, string>
                { 
            {"rotation", "4"},
 }),

                new BlockState(7049, new Dictionary<string, string>
                { 
            {"rotation", "5"},
 }),

                new BlockState(7050, new Dictionary<string, string>
                { 
            {"rotation", "6"},
 }),

                new BlockState(7051, new Dictionary<string, string>
                { 
            {"rotation", "7"},
 }),

                new BlockState(7052, new Dictionary<string, string>
                { 
            {"rotation", "8"},
 }),

                new BlockState(7053, new Dictionary<string, string>
                { 
            {"rotation", "9"},
 }),

                new BlockState(7054, new Dictionary<string, string>
                { 
            {"rotation", "10"},
 }),

                new BlockState(7055, new Dictionary<string, string>
                { 
            {"rotation", "11"},
 }),

                new BlockState(7056, new Dictionary<string, string>
                { 
            {"rotation", "12"},
 }),

                new BlockState(7057, new Dictionary<string, string>
                { 
            {"rotation", "13"},
 }),

                new BlockState(7058, new Dictionary<string, string>
                { 
            {"rotation", "14"},
 }),

                new BlockState(7059, new Dictionary<string, string>
                { 
            {"rotation", "15"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Green_bannerItem() };

        }
    }
}
