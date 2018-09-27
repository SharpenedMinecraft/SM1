
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Mushroom_stemBlock : Block
    {
        public override string BlockId => "minecraft:mushroom_stem";
        public override BlockState[] PossibleStates { get; }
        public Mushroom_stemBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(4097, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4098, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4099, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4100, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4101, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4102, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4103, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4104, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4105, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4106, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4107, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4108, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4109, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4110, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4111, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4112, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4113, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4114, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4115, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4116, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4117, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4118, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4119, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4120, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4121, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4122, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4123, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4124, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4125, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4126, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4127, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4128, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4129, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4130, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4131, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4132, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4133, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4134, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4135, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4136, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4137, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4138, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4139, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4140, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4141, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4142, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4143, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4144, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4145, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4146, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4147, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4148, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4149, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4150, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4151, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4152, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4153, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4154, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4155, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4156, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(4157, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(4158, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(4159, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(4160, new Dictionary<string, string>
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

            Drops = new ItemStack[] { new Mushroom_stemItem() };

        }
    }
}
