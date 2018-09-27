
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Brown_mushroom_blockBlock : Block
    {
        public override string BlockId => "minecraft:brown_mushroom_block";
        public override BlockState[] PossibleStates { get; }
        public Brown_mushroom_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3969, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3970, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3971, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3972, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3973, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3974, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3975, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3976, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3977, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3978, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3979, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3980, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3981, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3982, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3983, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3984, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3985, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3986, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3987, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3988, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3989, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3990, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3991, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3992, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3993, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3994, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3995, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(3996, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(3997, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(3998, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(3999, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4000, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4001, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4002, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4003, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4004, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4005, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4006, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4007, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4008, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4009, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4010, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4011, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4012, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4013, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4014, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4015, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4016, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4017, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4018, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4019, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4020, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4021, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4022, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4023, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4024, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4025, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4026, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4027, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4028, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4029, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4030, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4031, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4032, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Brown_mushroom_blockItem() };

        }
    }
}
