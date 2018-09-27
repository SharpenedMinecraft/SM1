
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Red_mushroom_blockBlock : Block
    {
        public override string BlockId => "minecraft:red_mushroom_block";
        public override BlockState[] PossibleStates { get; }
        public Red_mushroom_blockBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4033, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4034, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4035, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4036, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4037, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4038, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4039, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4040, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4041, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4042, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4043, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4044, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4045, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4046, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4047, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4048, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4049, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4050, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4051, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4052, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4053, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4054, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4055, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4056, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4057, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4058, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4059, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4060, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4061, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4062, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4063, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4064, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4065, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4066, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4067, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4068, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4069, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4070, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4071, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4072, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4073, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4074, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4075, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4076, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4077, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4078, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4079, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4080, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4081, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4082, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4083, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4084, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4085, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4086, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4087, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4088, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4089, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4090, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4091, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4092, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4093, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4094, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4095, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4096, new Dictionary<string, string>
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

            Drops = new ItemStack[] { new Red_mushroom_blockItem() };

        }
    }
}
