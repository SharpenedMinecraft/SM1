
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Player_wall_headBlock : Block
    {
        public override string BlockId => "minecraft:player_wall_head";
        public override BlockState[] PossibleStates { get; }
        public Player_wall_headBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(5489, new Dictionary<string, string>
                { 
            {"facing", "north"},
 }),

                new BlockState(5490, new Dictionary<string, string>
                { 
            {"facing", "east"},
 }),

                new BlockState(5491, new Dictionary<string, string>
                { 
            {"facing", "south"},
 }),

                new BlockState(5492, new Dictionary<string, string>
                { 
            {"facing", "west"},
 }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] {  };

        }
    }
}
