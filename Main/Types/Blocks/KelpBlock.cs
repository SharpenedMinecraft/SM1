
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class KelpBlock : Block
    {
        public override string BlockId => "minecraft:kelp";
        public override BlockState[] PossibleStates { get; }
        public KelpBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(8392, new Dictionary<string, string>
                { 
            {"age", "0"},
 }),

                new BlockState(8393, new Dictionary<string, string>
                { 
            {"age", "1"},
 }),

                new BlockState(8394, new Dictionary<string, string>
                { 
            {"age", "2"},
 }),

                new BlockState(8395, new Dictionary<string, string>
                { 
            {"age", "3"},
 }),

                new BlockState(8396, new Dictionary<string, string>
                { 
            {"age", "4"},
 }),

                new BlockState(8397, new Dictionary<string, string>
                { 
            {"age", "5"},
 }),

                new BlockState(8398, new Dictionary<string, string>
                { 
            {"age", "6"},
 }),

                new BlockState(8399, new Dictionary<string, string>
                { 
            {"age", "7"},
 }),

                new BlockState(8400, new Dictionary<string, string>
                { 
            {"age", "8"},
 }),

                new BlockState(8401, new Dictionary<string, string>
                { 
            {"age", "9"},
 }),

                new BlockState(8402, new Dictionary<string, string>
                { 
            {"age", "10"},
 }),

                new BlockState(8403, new Dictionary<string, string>
                { 
            {"age", "11"},
 }),

                new BlockState(8404, new Dictionary<string, string>
                { 
            {"age", "12"},
 }),

                new BlockState(8405, new Dictionary<string, string>
                { 
            {"age", "13"},
 }),

                new BlockState(8406, new Dictionary<string, string>
                { 
            {"age", "14"},
 }),

                new BlockState(8407, new Dictionary<string, string>
                { 
            {"age", "15"},
 }),

                new BlockState(8408, new Dictionary<string, string>
                { 
            {"age", "16"},
 }),

                new BlockState(8409, new Dictionary<string, string>
                { 
            {"age", "17"},
 }),

                new BlockState(8410, new Dictionary<string, string>
                { 
            {"age", "18"},
 }),

                new BlockState(8411, new Dictionary<string, string>
                { 
            {"age", "19"},
 }),

                new BlockState(8412, new Dictionary<string, string>
                { 
            {"age", "20"},
 }),

                new BlockState(8413, new Dictionary<string, string>
                { 
            {"age", "21"},
 }),

                new BlockState(8414, new Dictionary<string, string>
                { 
            {"age", "22"},
 }),

                new BlockState(8415, new Dictionary<string, string>
                { 
            {"age", "23"},
 }),

                new BlockState(8416, new Dictionary<string, string>
                { 
            {"age", "24"},
 }),

                new BlockState(8417, new Dictionary<string, string>
                { 
            {"age", "25"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new KelpItem() };

        }
    }
}
