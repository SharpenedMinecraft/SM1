
using SharpenedMinecraft.Types.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenedMinecraft.Types.Blocks
{
    public class Mob_spawnerBlock : Block
    {
        public override string BlockId => "minecraft:mob_spawner";
        public override BlockState[] PossibleStates { get; }
        public Mob_spawnerBlock() : base()
        {

            PossibleStates = new BlockState[]
            {
                new BlockState(1629, new Dictionary<string, string>
                {  }),

            };
            State = PossibleStates[0];

            Drops = new ItemStack[] { new Mob_spawnerItem() };

        }
    }
}
