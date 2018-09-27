
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Chorus_plantBlock : Block
    {
        public override string BlockId => "minecraft:chorus_plant";
        public override BlockState[] PossibleStates { get; }
        public Chorus_plantBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(7985, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(7986, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(7987, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(7988, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(7989, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(7990, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(7991, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(7992, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(7993, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(7994, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(7995, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(7996, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(7997, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(7998, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(7999, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8000, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8001, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8002, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8003, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8004, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8005, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8006, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8007, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8008, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8009, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8010, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8011, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8012, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8013, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8014, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8015, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8016, new Dictionary<string, string>
                { 
            {"down", "true"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8017, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8018, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8019, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8020, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8021, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8022, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8023, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8024, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8025, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8026, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8027, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8028, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8029, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8030, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8031, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8032, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "true"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8033, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8034, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8035, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8036, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8037, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8038, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8039, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8040, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "true"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8041, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8042, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8043, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8044, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "true"},

            {"up", "false"},

            {"west", "false"},
 }),

                new BlockState(8045, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "true"},
 }),

                new BlockState(8046, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "true"},

            {"west", "false"},
 }),

                new BlockState(8047, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "true"},
 }),

                new BlockState(8048, new Dictionary<string, string>
                { 
            {"down", "false"},

            {"east", "false"},

            {"north", "false"},

            {"south", "false"},

            {"up", "false"},

            {"west", "false"},
 }),

            };
            State = PossibleStates[63];

            Drops = new ItemStack[] { new Chorus_plantItem() };

        }
    }
}
