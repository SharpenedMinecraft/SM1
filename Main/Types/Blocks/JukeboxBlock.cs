
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class JukeboxBlock : Block
    {
        public override string BlockId => "minecraft:jukebox";
        public override BlockState[] PossibleStates { get; }
        public JukeboxBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(3440, new Dictionary<string, string>
                { 
            {"has_record", "true"},
 }),

                new BlockState(3441, new Dictionary<string, string>
                { 
            {"has_record", "false"},
 }),

            };
            State = PossibleStates[1];

            Drops = new ItemStack[] { new JukeboxItem() };

        }
    }
}
